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
			<px:PXLayoutRule ControlSize="SM" LabelsWidth="M" ID="PXLayoutRule1" runat="server" StartRow="True"></px:PXLayoutRule>
			<px:PXSegmentMask runat="server" ID="CstPXSegmentMask2" DataField="BAccountID" />
			<px:PXSegmentMask runat="server" ID="CstPXSegmentMask14" DataField="InventoryID" />
			<px:PXDateTimeEdit runat="server" ID="CstPXDateTimeEdit1" DataField="AsOfDate" />
			<px:PXCheckBox runat="server" ID="CstPXCheckBox11" DataField="EnvironmentallyControlled" />
			<px:PXNumberEdit runat="server" ID="CstPXNumberEdit3" DataField="CarbonEmissions" />
			<px:PXSelector Size="S" runat="server" ID="CstPXSelector4" DataField="CarbonEmissionsUOM" ></px:PXSelector>
			<px:PXNumberEdit runat="server" ID="CstPXNumberEdit9" DataField="ElectricUsage" />
			<px:PXSelector Size="S" runat="server" ID="CstPXSelector10" DataField="ElectricUsageUOM" ></px:PXSelector>
			<px:PXNumberEdit runat="server" ID="CstPXNumberEdit12" DataField="GasUsage" />
			<px:PXSelector Size="S" runat="server" ID="CstPXSelector13" DataField="GasUsageUOM" ></px:PXSelector>
			<px:PXNumberEdit runat="server" ID="CstPXNumberEdit15" DataField="OilUsage" />
			<px:PXSelector Size="S" runat="server" ID="CstPXSelector16" DataField="OilUsagewUOM" ></px:PXSelector>
			<px:PXNumberEdit runat="server" ID="CstPXNumberEdit19" DataField="WaterConsumption" />
			<px:PXSelector Size="S" runat="server" ID="CstPXSelector20" DataField="WaterConsumptionUOM" ></px:PXSelector>
			<px:PXNumberEdit runat="server" ID="CstPXNumberEdit17" DataField="RecycledWaste" />
			<px:PXSelector Size="S" runat="server" ID="CstPXSelector18" DataField="RecycledWasteUOM" ></px:PXSelector></Template>
		<AutoSize Container="Window" Enabled="True" MinHeight="200" ></AutoSize>
	</px:PXFormView>
</asp:Content>