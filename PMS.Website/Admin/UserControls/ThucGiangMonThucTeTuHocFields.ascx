<%@ Control Language="C#" ClassName="ThucGiangMonThucTeTuHocFields" %>

<asp:FormView ID="FormView1" runat="server">
	<ItemTemplate>
		<table border="0" cellpadding="3" cellspacing="1">
			<tr>
        <td class="literal"><asp:Label ID="lbldataNamHoc" runat="server" Text="Nam Hoc:" AssociatedControlID="dataNamHoc" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNamHoc" Text='<%# Bind("NamHoc") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataHocKy" runat="server" Text="Hoc Ky:" AssociatedControlID="dataHocKy" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHocKy" Text='<%# Bind("HocKy") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaLopHocPhan" runat="server" Text="Ma Lop Hoc Phan:" AssociatedControlID="dataMaLopHocPhan" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaLopHocPhan" Text='<%# Bind("MaLopHocPhan") %>' MaxLength="50"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaHeSoCongViec" runat="server" Text="Ma He So Cong Viec:" AssociatedControlID="dataMaHeSoCongViec" /></td>
        <td>
					<data:EntityDropDownList runat="server" ID="dataMaHeSoCongViec" DataSourceID="MaHeSoCongViecHeSoCongViecDataSource" DataTextField="Stt" DataValueField="MaHeSo" SelectedValue='<%# Bind("MaHeSoCongViec") %>' AppendNullItem="true" Required="false" NullItemText="< Please Choose ...>" />
					<data:HeSoCongViecDataSource ID="MaHeSoCongViecHeSoCongViecDataSource" runat="server" SelectMethod="GetAll"  />
				</td>
			</tr>
			
		</table>

	</ItemTemplate>
</asp:FormView>


