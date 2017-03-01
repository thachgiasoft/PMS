<%@ Control Language="C#" ClassName="NghienCuuKhoaHocTongHopFields" %>

<asp:FormView ID="FormView1" runat="server">
	<ItemTemplate>
		<table border="0" cellpadding="3" cellspacing="1">
			<tr>
        <td class="literal"><asp:Label ID="lbldataSoTietDuocTru" runat="server" Text="So Tiet Duoc Tru:" AssociatedControlID="dataSoTietDuocTru" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataSoTietDuocTru" Text='<%# Bind("SoTietDuocTru") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataSoTietDuocTru" runat="server" Display="Dynamic" ControlToValidate="dataSoTietDuocTru" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTong" runat="server" Text="Tong:" AssociatedControlID="dataTong" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTong" Text='<%# Bind("Tong") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataTong" runat="server" Display="Dynamic" ControlToValidate="dataTong" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataGhiChu" runat="server" Text="Ghi Chu:" AssociatedControlID="dataGhiChu" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataGhiChu" Text='<%# Bind("GhiChu") %>'  TextMode="MultiLine"  Width="250px" Rows="5"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataSoTietChuyenSangKySau" runat="server" Text="So Tiet Chuyen Sang Ky Sau:" AssociatedControlID="dataSoTietChuyenSangKySau" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataSoTietChuyenSangKySau" Text='<%# Bind("SoTietChuyenSangKySau") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataSoTietChuyenSangKySau" runat="server" Display="Dynamic" ControlToValidate="dataSoTietChuyenSangKySau" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataSoTietThucHien" runat="server" Text="So Tiet Thuc Hien:" AssociatedControlID="dataSoTietThucHien" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataSoTietThucHien" Text='<%# Bind("SoTietThucHien") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataSoTietThucHien" runat="server" Display="Dynamic" ControlToValidate="dataSoTietThucHien" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataHocKy" runat="server" Text="Hoc Ky:" AssociatedControlID="dataHocKy" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHocKy" Text='<%# Bind("HocKy") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNamHoc" runat="server" Text="Nam Hoc:" AssociatedControlID="dataNamHoc" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNamHoc" Text='<%# Bind("NamHoc") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataSoTietKyTruocChuyenSang" runat="server" Text="So Tiet Ky Truoc Chuyen Sang:" AssociatedControlID="dataSoTietKyTruocChuyenSang" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataSoTietKyTruocChuyenSang" Text='<%# Bind("SoTietKyTruocChuyenSang") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataSoTietKyTruocChuyenSang" runat="server" Display="Dynamic" ControlToValidate="dataSoTietKyTruocChuyenSang" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
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


