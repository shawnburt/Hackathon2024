using PX.Data;
using PX.Objects.CR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESGHackathon2024.Attributes
{
    #region GendersAttribute

    public class ESGGendersAttribute : PXStringListAttribute
    {
        public const string Male = "M";
        public const string Female = "F";
        public const string NonBinary = "N";
        public const string Unspecified = "X";
        public const string Other = "O";
        public class Labels
        {
            public const string Male = "Male";

            public const string Female = "Female";
            public const string NonBinary = "NonBinary";
            public const string Unspecified = "Unspecified";
            public const string Other = "Other";
        }
        private readonly Type _titleField;

        public ESGGendersAttribute(Type titleField)
            : this()
        {
            if (titleField == null) throw new ArgumentNullException("titleField");
            _titleField = titleField;
        }

        public ESGGendersAttribute()
            : base(new[] { Male, Female ,NonBinary,Unspecified,Other }, new[] { Labels.Male, Labels.Female,Labels.NonBinary,Labels.Unspecified,Labels.Other })
        {

        }

        public override void CacheAttached(PXCache sender)
        {
            base.CacheAttached(sender);

            if (_titleField != null)
            {
                sender.Graph.RowInserted.AddHandler(_BqlTable, RowInsertedHandler);
                sender.Graph.RowUpdated.AddHandler(_BqlTable, RowUpdatedHandler);
            }
        }

        private void RowInsertedHandler(PXCache sender, PXRowInsertedEventArgs e)
        {
            var gender = sender.GetValue(e.Row, _FieldName);
            if (gender == null)
            {
                var title = sender.GetValue(e.Row, _titleField.Name) as string;
                if (title != null)
                {
                    object newVal = null;
                    switch (title)
                    {
                        case TitlesAttribute.Mr:
                            newVal = Male;
                            break;
                        case TitlesAttribute.Ms:
                        case TitlesAttribute.Miss:
                        case TitlesAttribute.Mrs:
                            newVal = Female;
                            break;
                    }
                    sender.SetValue(e.Row, _FieldName, newVal);
                }
            }
        }

        private void RowUpdatedHandler(PXCache sender, PXRowUpdatedEventArgs e)
        {
            var gender = sender.GetValue(e.Row, _FieldName);
            var oldGender = sender.GetValue(e.OldRow, _FieldName);
            var title = sender.GetValue(e.Row, _titleField.Name) as string;
            var oldlTitle = sender.GetValue(e.OldRow, _titleField.Name) as string;
            if (gender == oldGender && title != null && title != oldlTitle)
            {
                object newVal = null;
                switch (title)
                {
                    case TitlesAttribute.Mr:
                        newVal = Male;
                        break;
                    case TitlesAttribute.Ms:
                    case TitlesAttribute.Miss:
                    case TitlesAttribute.Mrs:
                        newVal = Female;
                        break;
                }
                if (newVal != null) sender.SetValue(e.Row, _FieldName, newVal);
            }
        }

        public class male : PX.Data.BQL.BqlString.Constant<male>
        {
            public male() : base(Male) { }
        }

        public class female : PX.Data.BQL.BqlString.Constant<female>
        {
            public female() : base(Female) { }
        }
    }

    #endregion

}
