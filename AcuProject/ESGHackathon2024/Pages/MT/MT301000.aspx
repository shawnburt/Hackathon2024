<%@ Page Language="C#" MasterPageFile="~/MasterPages/FormView.master" AutoEventWireup="true" ValidateRequest="false" CodeFile="MT301000.aspx.cs" Inherits="Page_MT301000" Title="Untitled Page" %>
<%@ MasterType VirtualPath="~/MasterPages/FormView.master" %>

<asp:Content ID="cont1" ContentPlaceHolderID="phDS" Runat="Server">
	<px:PXDataSource ID="ds" runat="server" Visible="True" Width="100%"
        TypeName="ESGHackathon2024.MATIncidentEntry" UDFTypeField="IncidentType"
        PrimaryView="Document"
        >
		<CallbackCommands>

		</CallbackCommands>
	</px:PXDataSource>
</asp:Content>
<asp:Content ID="cont2" ContentPlaceHolderID="phF" Runat="Server">
	<px:PXFormView ID="form" runat="server" DataSourceID="ds" DataMember="Document" Width="100%" AllowAutoHide="false">
		<Template>
			<px:PXLayoutRule ID="PXLayoutRule1" runat="server" StartRow="True"></px:PXLayoutRule>
			<px:PXSelector ID="edIncidentType" aurelia="true" runat="server" DataField="IncidentType" AutoRefresh="True" DataSourceID="ds">
                <GridProperties>
                    <Layout ColumnsMenu="False" />
                </GridProperties>
            </px:PXSelector>
            <px:PXSelector ID="edIncidentNbr" runat="server" DataField="IncidentNbr" AutoRefresh="True" DataSourceID="ds">
                <GridProperties>
                    <Layout ColumnsMenu="False" />
                </GridProperties>
            </px:PXSelector>
			<px:PXSelector ID="edIncidentClass" runat="server" DataField="IncidentClass" AutoRefresh="True" DataSourceID="ds">
            </px:PXSelector>
            <px:PXDropDown ID="edStatus" runat="server" DataField="Status" Enabled="False" />
            <px:PXDateTimeEdit ID="edOrderDate" runat="server" DataField="IncidentDate">
                <AutoCallBack Command="Save" Target="form" />
            </px:PXDateTimeEdit>
            <px:PXDateTimeEdit CommitChanges="True" ID="CompletionDate" runat="server" DataField="CompletionDate" />
			<px:PXTextEdit ID="edDescription" runat="server" DataField="Description" TextMode="MultiLine" Height="55" />
			<px:PXLayoutRule runat="server" ID="CstPXLayoutRule5" StartColumn="True" />
			<px:PXSelector AllowEdit="True" runat="server" ID="edBAccountID" DataField="BAccountID" ></px:PXSelector>
			<px:PXSelector AllowEdit="True" runat="server" ID="edFixedAssetID" DataField="FixedAssetID" ></px:PXSelector>
			</Template>
		<AutoSize Container="Window" Enabled="True" MinHeight="200" ></AutoSize>
	</px:PXFormView>
</asp:Content>