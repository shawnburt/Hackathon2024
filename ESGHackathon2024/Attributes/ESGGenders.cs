using System;
using PX.Common;
using PX.Data;
using PX.Data.BQL;
using PX.Objects.CR;

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

        [PXLocalizable(MATMessages.MATError)]
        public class Labels
        {
            public const string Male = "Male";
            public const string Female = "Female";
            public const string NonBinary = "NonBinary";
            public const string Unspecified = "Unspecified";
            public const string Other = "Other";
        }

        private readonly Type _titleField;

        public ESGGendersAttribute(Type titleField) : this()
        {
            _titleField = titleField ?? throw new ArgumentNullException("titleField");
        }

        public ESGGendersAttribute() : base(new[] { Male, Female, NonBinary, Unspecified, Other }
            , new[] { Labels.Male, Labels.Female, Labels.NonBinary, Labels.Unspecified, Labels.Other })
        { }

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
                string title = (string)sender.GetValue(e.Row, _titleField.Name);
                if (title != null)
                {
                    string newVal = null;
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
        }

        private void RowUpdatedHandler(PXCache sender, PXRowUpdatedEventArgs e)
        {
            string gender = (string)sender.GetValue(e.Row, _FieldName);
            string oldGender = (string)sender.GetValue(e.OldRow, _FieldName);
            string title = (string)sender.GetValue(e.Row, _titleField.Name);
            string oldlTitle = (string)sender.GetValue(e.OldRow, _titleField.Name);
            if (gender == oldGender && title != null && title != oldlTitle)
            {
                string newVal = null;
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

        public class male : BqlString.Constant<male>
        {
            public male() : base(Male) { }
        }

        public class female : BqlString.Constant<female>
        {
            public female() : base(Female) { }
        }
    }
    #endregion
}