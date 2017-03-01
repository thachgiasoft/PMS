<%@ Control Language="C#" ClassName="GiangVienLopHocPhanFields" %>

<asp:FormView ID="FormView1" runat="server">
	<ItemTemplate>
		<table border="0" cellpadding="3" cellspacing="1">
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaHeSoNn" runat="server" Text="Ma He So Nn:" AssociatedControlID="dataMaHeSoNn" /></td>
        <td>
					<data:EntityDropDownList runat="server" ID="dataMaHeSoNn" DataSourceID="MaHeSoNnHeSoNgonNguDataSource" DataTextField="Stt" DataValueField="MaHeSo" SelectedValue='<%# Bind("MaHeSoNn") %>' AppendNullItem="true" Required="false" NullItemText="< Please Choose ...>" />
					<data:HeSoNgonNguDataSource ID="MaHeSoNnHeSoNgonNguDataSource" runat="server" SelectMethod="GetAll"  />
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaLopHocPhan" runat="server" Text="Ma Lop Hoc Phan:" AssociatedControlID="dataMaLopHocPhan" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaLopHocPhan" Text='<%# Bind("MaLopHocPhan") %>' MaxLength="20"></asp:TextBox><asp:RequiredFieldValidator ID="ReqVal_dataMaLopHocPhan" runat="server" Display="Dynamic" ControlToValidate="dataMaLopHocPhan" ErrorMessage="Required"></asp:RequiredFieldValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaGiangVien" runat="server" Text="Ma Giang Vien:" AssociatedControlID="dataMaGiangVien" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaGiangVien" Text='<%# Bind("MaGiangVien") %>'></asp:TextBox><asp:RequiredFieldValidator ID="ReqVal_dataMaGiangVien" runat="server" Display="Dynamic" ControlToValidate="dataMaGiangVien" ErrorMessage="Required"></asp:RequiredFieldValidator><asp:RangeValidator ID="RangeVal_dataMaGiangVien" runat="server" Display="Dynamic" ControlToValidate="dataMaGiangVien" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			
		</table>

	</ItemTemplate>
</asp:FormView>


