<%@ Page Language="C#" MasterPageFile="~/MasterPages/ListView.master" AutoEventWireup="true" ValidateRequest="false" CodeFile="MT203050.aspx.cs" Inherits="Page_MT203050" Title="Untitled Page" %>
<%@ MasterType VirtualPath="~/MasterPages/ListView.master" %>

<asp:Content ID="cont1" ContentPlaceHolderID="phDS" runat="Server">
	<px:PXDataSource ID="ds" Width="100%" runat="server" PrimaryView="Records" TypeName="ESGHackathon2024.MATIncidentClassMaint" Visible="True">
    </px:PXDataSource>
</asp:Content>
<asp:Content ID="cont2" ContentPlaceHolderID="phL" runat="Server">
	<px:PXGrid ID="grid" runat="server" Height="400px" Width="100%" Style="z-index: 100" ActionsPosition="Top"
        AllowSearch="true" DataSourceID="ds" SkinID="Primary" FastFilterFields="IncidentClassID,Description">
        <Levels>
            <px:PXGridLevel DataMember="Records">
                <RowTemplate>
                    <px:PXLayoutRule runat="server" StartColumn="True" LabelsWidth="M" ControlSize="XM" />
                    <px:PXMaskEdit ID="edIncidentClassID" runat="server" DataField="IncidentClassID" InputMask="&gt;aaaaaaaaaa" />
                    <px:PXTextEdit ID="edDescription" runat="server" DataField="Description" />
					<px:PXSelector ID="edIncidentTypeID" runat="server" DataField="IncidentTypeID" AllowEdit="True" />
                </RowTemplate>
                <Columns>
                    <px:PXGridColumn DataField="IncidentClassID" DisplayFormat="&gt;aaaaaaaaaa" Width="100px" />
                    <px:PXGridColumn DataField="Description" Width="300px" />
					<px:PXGridColumn DataField="IncidentTypeID" Width="100px" />
                </Columns>
            </px:PXGridLevel>
        </Levels>
        <AutoSize Container="Window" Enabled="True" MinHeight="200" />
    </px:PXGrid>
</asp:Content>
