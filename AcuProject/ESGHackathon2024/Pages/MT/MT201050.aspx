<%@ Page Language="C#" MasterPageFile="~/MasterPages/ListView.master" AutoEventWireup="true" ValidateRequest="false" CodeFile="MT201050.aspx.cs" Inherits="Page_MT201050" Title="Untitled Page" %>
<%@ MasterType VirtualPath="~/MasterPages/ListView.master" %>

<asp:Content ID="cont1" ContentPlaceHolderID="phDS" runat="Server">
	<px:PXDataSource ID="ds" Width="100%" runat="server" PrimaryView="Records" TypeName="ESGHackathon2024.MATEthnicityMaint" Visible="True">
    </px:PXDataSource>
</asp:Content>
<asp:Content ID="cont2" ContentPlaceHolderID="phL" runat="Server">
	<px:PXGrid ID="grid" runat="server" Height="400px" Width="100%" Style="z-index: 100" ActionsPosition="Top"
        AllowSearch="true" DataSourceID="ds" SkinID="Primary" FastFilterFields="EthnicityID,Description">
        <Levels>
            <px:PXGridLevel DataMember="Records">
                <RowTemplate>
                    <px:PXLayoutRule runat="server" StartColumn="True" LabelsWidth="M" ControlSize="XM" />
                    <px:PXMaskEdit ID="edEthnicityID" runat="server" DataField="EthnicityID" InputMask="&gt;aaaaaaaaaa" />
					<px:PXSelector ID="edRaceID" runat="server" DataField="RaceID" AllowEdit="True" AutoCallback="True"/>
                    <px:PXTextEdit ID="edDescription" runat="server" DataField="Description" />
                </RowTemplate>
                <Columns>
                    <px:PXGridColumn DataField="EthnicityID" DisplayFormat="&gt;aaaaaaaaaa" Width="100px" />
					<px:PXGridColumn DataField="RaceID" AutoCallBack="True"/>
                    <px:PXGridColumn DataField="Description" Width="300px" />
                </Columns>
            </px:PXGridLevel>
        </Levels>
        <AutoSize Container="Window" Enabled="True" MinHeight="200" />
    </px:PXGrid>
</asp:Content>
