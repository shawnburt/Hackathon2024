<%@ Page Language="C#" MasterPageFile="~/MasterPages/ListView.master" AutoEventWireup="true" ValidateRequest="false" CodeFile="MT203000.aspx.cs" Inherits="Page_MT203000" Title="Untitled Page" %>
<%@ MasterType VirtualPath="~/MasterPages/ListView.master" %>

<asp:Content ID="cont1" ContentPlaceHolderID="phDS" runat="Server">
	<px:PXDataSource ID="ds" Width="100%" runat="server" PrimaryView="Records" TypeName="ESGHackathon2024.MATIncidentTypeMaint" Visible="True">
    </px:PXDataSource>
</asp:Content>
<asp:Content ID="cont2" ContentPlaceHolderID="phL" runat="Server">
	<px:PXGrid ID="grid" runat="server" Height="400px" Width="100%" Style="z-index: 100" ActionsPosition="Top"
        AllowSearch="true" DataSourceID="ds" SkinID="Primary" FastFilterFields="IncidentTypeID,Description">
        <Levels>
            <px:PXGridLevel DataMember="Records">
                <RowTemplate>
                    <px:PXLayoutRule runat="server" StartColumn="True" LabelsWidth="M" ControlSize="XM" />
                    <px:PXMaskEdit ID="edIncidentTypeID" runat="server" DataField="IncidentTypeID" InputMask="&gt;aaaaaaaaaa" />
                    <px:PXTextEdit ID="edDescription" runat="server" DataField="Description" />
					<px:PXSelector ID="edNumberingID" runat="server" DataField="NumberingID" AllowEdit="True" />
                </RowTemplate>
                <Columns>
                    <px:PXGridColumn DataField="IncidentTypeID" DisplayFormat="&gt;aaaaaaaaaa" Width="100px" />
                    <px:PXGridColumn DataField="Description" Width="300px" />
					<px:PXGridColumn DataField="NumberingID" Width="100px" />
                </Columns>
            </px:PXGridLevel>
        </Levels>
        <AutoSize Container="Window" Enabled="True" MinHeight="200" />
    </px:PXGrid>
</asp:Content>
