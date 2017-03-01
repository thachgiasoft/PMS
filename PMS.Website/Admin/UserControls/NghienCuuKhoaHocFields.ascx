<%@ Control Language="C#" ClassName="NghienCuuKhoaHocFields" %>

<asp:FormView ID="FormView1" runat="server">
	<ItemTemplate>
		<table border="0" cellpadding="3" cellspacing="1">
			<tr>
        <td class="literal"><asp:Label ID="lbldataHocKy" runat="server" Text="Hoc Ky:" AssociatedControlID="dataHocKy" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHocKy" Text='<%# Bind("HocKy") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataSoTietThucHien" runat="server" Text="So Tiet Thuc Hien:" AssociatedControlID="dataSoTietThucHien" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataSoTietThucHien" Text='<%# Bind("SoTietThucHien") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataSoTietThucHien" runat="server" Display="Dynamic" ControlToValidate="dataSoTietThucHien" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataSoTietDinhMuc" runat="server" Text="So Tiet Dinh Muc:" AssociatedControlID="dataSoTietDinhMuc" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataSoTietDinhMuc" Text='<%# Bind("SoTietDinhMuc") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataSoTietDinhMuc" runat="server" Display="Dynamic" ControlToValidate="dataSoTietDinhMuc" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNamHoc" runat="server" Text="Nam Hoc:" AssociatedControlID="dataNamHoc" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNamHoc" Text='<%# Bind("NamHoc") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaGiangVien" runat="server" Text="Ma Giang Vien:" AssociatedControlID="dataMaGiangVien" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaGiangVien" Text='<%# Bind("MaGiangVien") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataMaGiangVien" runat="server" Display="Dynamic" ControlToValidate="dataMaGiangVien" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			
		</table>

	</ItemTemplate>
</asp:FormView>


