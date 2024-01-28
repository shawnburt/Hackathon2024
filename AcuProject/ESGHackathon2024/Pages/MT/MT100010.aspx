<%@ Page Language="C#" MasterPageFile="~/MasterPages/ListView.master" AutoEventWireup="true" ValidateRequest="false" CodeFile="MT100010.aspx.cs" Inherits="Page_MT100010" Title="Untitled Page" %>
<%@ MasterType VirtualPath="~/MasterPages/ListView.master" %>

<asp:Content ID="cont1" ContentPlaceHolderID="phDS" Runat="Server">
	<px:PXDataSource ID="ds" runat="server" Visible="True" Width="100%"
        TypeName="ESGHackathon2024.MATTrainingTypeMaint"
        PrimaryView="Document">
	</px:PXDataSource>
</asp:Content>
<asp:Content ID="cont2" ContentPlaceHolderID="phL" Runat="Server">
	
	<px:PXGrid ID="grid" runat="server" Height="400px" Width="100%" Style="z-index: 100" ActionsPosition="Top"
        AllowSearch="true" DataSourceID="ds" SkinID="Details" FastFilterFields="TrainingTypeCD,Descr">
        <Levels>
            <px:PXGridLevel DataMember="Document">
                <RowTemplate>
                    <px:PXLayoutRule runat="server" StartColumn="True" LabelsWidth="M" ControlSize="XM" ></px:PXLayoutRule>
                    <px:PXTextEdit runat="server" ID="CstPXTextEdit2" DataField="TrainingTypeCD" ></px:PXTextEdit>
					<px:PXTextEdit TextMode="MultiLine" Height="200px" Width="400px" runat="server" ID="CstPXTextEdit1" DataField="Descr" ></px:PXTextEdit>
                </RowTemplate>
                <Columns>
                    <px:PXGridColumn DataField="TrainingTypeCD"  ></px:PXGridColumn>
                    <px:PXGridColumn DataField="Descr" Width="400px" ></px:PXGridColumn>
                </Columns>
            </px:PXGridLevel>
        </Levels>
        <AutoSize Container="Window" Enabled="True" MinHeight="200" ></AutoSize>
    </px:PXGrid>
</asp:Content>