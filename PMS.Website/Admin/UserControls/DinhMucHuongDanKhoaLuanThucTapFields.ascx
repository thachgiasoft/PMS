<%@ Control Language="C#" ClassName="DinhMucHuongDanKhoaLuanThucTapFields" %>

<asp:FormView ID="FormView1" runat="server">
	<ItemTemplate>
		<table border="0" cellpadding="3" cellspacing="1">
			<tr>
        <td class="literal"><asp:Label ID="lbldataGhiChu" runat="server" Text="Ghi Chu:" AssociatedControlID="dataGhiChu" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataGhiChu" Text='<%# Bind("GhiChu") %>'  TextMode="MultiLine"  Width="250px" Rows="5"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNgayCapNhat" runat="server" Text="Ngay Cap Nhat:" AssociatedControlID="dataNgayCapNhat" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNgayCapNhat" Text='<%# Bind("NgayCapNhat", "{0:d}") %>' MaxLength="10"></asp:TextBox><asp:ImageButton ID="cal_dataNgayCapNhat" runat="server" SkinID="CalendarImageButton" OnClientClick="javascript:showCalendarControl(this.previousSibling);return false;" />
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNguoiCapNhat" runat="server" Text="Nguoi Cap Nhat:" AssociatedControlID="dataNguoiCapNhat" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNguoiCapNhat" Text='<%# Bind("NguoiCapNhat") %>' MaxLength="50"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaDonViTinh" runat="server" Text="Ma Don Vi Tinh:" AssociatedControlID="dataMaDonViTinh" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaDonViTinh" Text='<%# Bind("MaDonViTinh") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataMaDonViTinh" runat="server" Display="Dynamic" ControlToValidate="dataMaDonViTinh" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaHinhThucDaoTao" runat="server" Text="Ma Hinh Thuc Dao Tao:" AssociatedControlID="dataMaHinhThucDaoTao" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaHinhThucDaoTao" Text='<%# Bind("MaHinhThucDaoTao") %>' MaxLength="20"></asp:TextBox><asp:RequiredFieldValidator ID="ReqVal_dataMaHinhThucDaoTao" runat="server" Display="Dynamic" ControlToValidate="dataMaHinhThucDaoTao" ErrorMessage="Required"></asp:RequiredFieldValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaLoaiKhoiLuong" runat="server" Text="Ma Loai Khoi Luong:" AssociatedControlID="dataMaLoaiKhoiLuong" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaLoaiKhoiLuong" Text='<%# Bind("MaLoaiKhoiLuong") %>' MaxLength="20"></asp:TextBox><asp:RequiredFieldValidator ID="ReqVal_dataMaLoaiKhoiLuong" runat="server" Display="Dynamic" ControlToValidate="dataMaLoaiKhoiLuong" ErrorMessage="Required"></asp:RequiredFieldValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataSoLuong" runat="server" Text="So Luong:" AssociatedControlID="dataSoLuong" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataSoLuong" Text='<%# Bind("SoLuong") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataSoLuong" runat="server" Display="Dynamic" ControlToValidate="dataSoLuong" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			
		</table>

	</ItemTemplate>
</asp:FormView>


