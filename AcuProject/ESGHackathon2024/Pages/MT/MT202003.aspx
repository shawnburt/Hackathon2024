<%@ Page Language="C#" MasterPageFile="~/MasterPages/FormView.master" AutoEventWireup="true" ValidateRequest="false" CodeFile="MT202003.aspx.cs" Inherits="Page_MT202003" Title="Untitled Page" %>
<%@ MasterType VirtualPath="~/MasterPages/FormView.master" %>

<asp:Content ID="cont1" ContentPlaceHolderID="phDS" Runat="Server">
	<px:PXDataSource ID="ds" runat="server" Visible="True" Width="100%"
        TypeName="ESGHackathon2024.MATBAccountItemUsageMaint"
        PrimaryView="BAccountItemUsages"
        >
		<CallbackCommands>

		</CallbackCommands>
	</px:PXDataSource>
</asp:Content>
<asp:Content ID="cont2" ContentPlaceHolderID="phF" Runat="Server">
	<px:PXFormView ID="form" runat="server" DataSourceID="ds" DataMember="BAccountItemUsages" Width="100%" AllowAutoHide="false">
		<Template>
			<px:PXLayoutRule ControlSize="M" LabelsWidth="M" ID="PXLayoutRule1" runat="server" StartRow="True"></px:PXLayoutRule>
			<px:PXSegmentMask runat="server" ID="CstPXSegmentMask2" DataField="BAccountID" ></px:PXSegmentMask>
			<px:PXSegmentMask runat="server" ID="CstPXSegmentMask14" DataField="InventoryID" ></px:PXSegmentMask>
			<px:PXDateTimeEdit runat="server" ID="CstPXDateTimeEdit1" DataField="AsOfDate" ></px:PXDateTimeEdit>
			<px:PXCheckBox runat="server" ID="CstPXCheckBox11" DataField="EnvironmentallyControlled" ></px:PXCheckBox>
			<px:PXLayoutRule runat="server" ID="CstPXLayoutRule21" Merge="True" ></px:PXLayoutRule>
			<px:PXNumberEdit runat="server" ID="CstPXNumberEdit3" DataField="CarbonEmissions" ></px:PXNumberEdit>
			<px:PXSelector SuppressLabel="True" Size="S" runat="server" ID="CstPXSelector4" DataField="CarbonEmissionsUOM" ></px:PXSelector>
			<px:PXLayoutRule runat="server" ID="CstPXLayoutRule23" Merge="True" ></px:PXLayoutRule>
			<px:PXNumberEdit runat="server" ID="CstPXNumberEdit9" DataField="ElectricUsage" ></px:PXNumberEdit>
			<px:PXSelector SuppressLabel="True" Size="S" runat="server" ID="CstPXSelector10" DataField="ElectricUsageUOM" ></px:PXSelector>
			<px:PXLayoutRule runat="server" ID="CstPXLayoutRule25" Merge="True" ></px:PXLayoutRule>
			<px:PXNumberEdit runat="server" ID="CstPXNumberEdit12" DataField="GasUsage" ></px:PXNumberEdit>
			<px:PXSelector SuppressLabel="True" Size="S" runat="server" ID="CstPXSelector13" DataField="GasUsageUOM" ></px:PXSelector>
			<px:PXLayoutRule runat="server" ID="CstPXLayoutRule27" Merge="True" ></px:PXLayoutRule>
			<px:PXNumberEdit runat="server" ID="CstPXNumberEdit15" DataField="OilUsage" ></px:PXNumberEdit>
			<px:PXSelector SuppressLabel="True" Size="S" runat="server" ID="CstPXSelector16" DataField="OilUsagewUOM" ></px:PXSelector>
			<px:PXLayoutRule runat="server" ID="CstPXLayoutRule29" Merge="True" ></px:PXLayoutRule>
			<px:PXNumberEdit runat="server" ID="CstPXNumberEdit19" DataField="WaterConsumption" ></px:PXNumberEdit>
			<px:PXSelector SuppressLabel="True" Size="S" runat="server" ID="CstPXSelector20" DataField="WaterConsumptionUOM" ></px:PXSelector>
			<px:PXLayoutRule runat="server" ID="CstPXLayoutRule31" Merge="True" ></px:PXLayoutRule>
			<px:PXNumberEdit runat="server" ID="CstPXNumberEdit17" DataField="RecycledWaste" ></px:PXNumberEdit>
			<px:PXSelector SuppressLabel="True" Size="S" runat="server" ID="CstPXSelector18" DataField="RecycledWasteUOM" ></px:PXSelector></Template>
		<AutoSize Container="Window" Enabled="True" MinHeight="200" ></AutoSize>
	</px:PXFormView>
</asp:Content>