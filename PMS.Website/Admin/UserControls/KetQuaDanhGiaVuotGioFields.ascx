<%@ Control Language="C#" ClassName="KetQuaDanhGiaVuotGioFields" %>

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
        <td class="literal"><asp:Label ID="lbldataPhanTramDanhGia" runat="server" Text="Phan Tram Danh Gia:" AssociatedControlID="dataPhanTramDanhGia" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataPhanTramDanhGia" Text='<%# Bind("PhanTramDanhGia") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataPhanTramDanhGia" runat="server" Display="Dynamic" ControlToValidate="dataPhanTramDanhGia" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNguoiCapNhat" runat="server" Text="Nguoi Cap Nhat:" AssociatedControlID="dataNguoiCapNhat" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNguoiCapNhat" Text='<%# Bind("NguoiCapNhat") %>' MaxLength="50"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNgayCapNhat" runat="server" Text="Ngay Cap Nhat:" AssociatedControlID="dataNgayCapNhat" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNgayCapNhat" Text='<%# Bind("NgayCapNhat") %>' MaxLength="50"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataDanhGiaThoiGianThucHien" runat="server" Text="Danh Gia Thoi Gian Thuc Hien:" AssociatedControlID="dataDanhGiaThoiGianThucHien" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataDanhGiaThoiGianThucHien" Text='<%# Bind("DanhGiaThoiGianThucHien") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataDanhGiaThoiGianThucHien" runat="server" Display="Dynamic" ControlToValidate="dataDanhGiaThoiGianThucHien" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaGiangVien" runat="server" Text="Ma Giang Vien:" AssociatedControlID="dataMaGiangVien" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaGiangVien" Text='<%# Bind("MaGiangVien") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataMaGiangVien" runat="server" Display="Dynamic" ControlToValidate="dataMaGiangVien" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNamHoc" runat="server" Text="Nam Hoc:" AssociatedControlID="dataNamHoc" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNamHoc" Text='<%# Bind("NamHoc") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataThoiGianLamViecQuyDinh" runat="server" Text="Thoi Gian Lam Viec Quy Dinh:" AssociatedControlID="dataThoiGianLamViecQuyDinh" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataThoiGianLamViecQuyDinh" Text='<%# Bind("ThoiGianLamViecQuyDinh") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataThoiGianLamViecQuyDinh" runat="server" Display="Dynamic" ControlToValidate="dataThoiGianLamViecQuyDinh" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaNoiDungDanhGia" runat="server" Text="Ma Noi Dung Danh Gia:" AssociatedControlID="dataMaNoiDungDanhGia" /></td>
        <td>
					<data:EntityDropDownList runat="server" ID="dataMaNoiDungDanhGia" DataSourceID="MaNoiDungDanhGiaNoiDungDanhGiaDataSource" DataTextField="TenNoiDungDanhGia" DataValueField="MaQuanLy" SelectedValue='<%# Bind("MaNoiDungDanhGia") %>' AppendNullItem="true" Required="false" NullItemText="< Please Choose ...>" />
					<data:NoiDungDanhGiaDataSource ID="MaNoiDungDanhGiaNoiDungDanhGiaDataSource" runat="server" SelectMethod="GetAll"  />
				</td>
			</tr>
			
		</table>

	</ItemTemplate>
</asp:FormView>


