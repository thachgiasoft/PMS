<%@ Control Language="C#" ClassName="DonGiaFields" %>

<asp:FormView ID="FormView1" runat="server">
	<ItemTemplate>
		<table border="0" cellpadding="3" cellspacing="1">
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaHinhThucDaoTao" runat="server" Text="Ma Hinh Thuc Dao Tao:" AssociatedControlID="dataMaHinhThucDaoTao" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaHinhThucDaoTao" Text='<%# Bind("MaHinhThucDaoTao") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataBacDaoTao" runat="server" Text="Bac Dao Tao:" AssociatedControlID="dataBacDaoTao" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataBacDaoTao" Text='<%# Bind("BacDaoTao") %>'  TextMode="MultiLine"  Width="250px" Rows="5"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataDonGiaTrongChuan" runat="server" Text="Don Gia Trong Chuan:" AssociatedControlID="dataDonGiaTrongChuan" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataDonGiaTrongChuan" Text='<%# Bind("DonGiaTrongChuan") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataDonGiaTrongChuan" runat="server" Display="Dynamic" ControlToValidate="dataDonGiaTrongChuan" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataDonGiaNgoaiChuan" runat="server" Text="Don Gia Ngoai Chuan:" AssociatedControlID="dataDonGiaNgoaiChuan" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataDonGiaNgoaiChuan" Text='<%# Bind("DonGiaNgoaiChuan") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataDonGiaNgoaiChuan" runat="server" Display="Dynamic" ControlToValidate="dataDonGiaNgoaiChuan" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNgonNguGiangDay" runat="server" Text="Ngon Ngu Giang Day:" AssociatedControlID="dataNgonNguGiangDay" /></td>
        <td>
					<data:EntityDropDownList runat="server" ID="dataNgonNguGiangDay" DataSourceID="NgonNguGiangDayNgonNguGiangDayDataSource" DataTextField="TenNgonNgu" DataValueField="MaNgonNgu" SelectedValue='<%# Bind("NgonNguGiangDay") %>' AppendNullItem="true" Required="false" NullItemText="< Please Choose ...>" />
					<data:NgonNguGiangDayDataSource ID="NgonNguGiangDayNgonNguGiangDayDataSource" runat="server" SelectMethod="GetAll"  />
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaNhomMon" runat="server" Text="Ma Nhom Mon:" AssociatedControlID="dataMaNhomMon" /></td>
        <td>
					<data:EntityDropDownList runat="server" ID="dataMaNhomMon" DataSourceID="MaNhomMonNhomMonHocDataSource" DataTextField="MaQuanLy" DataValueField="MaNhomMon" SelectedValue='<%# Bind("MaNhomMon") %>' AppendNullItem="true" Required="false" NullItemText="< Please Choose ...>" />
					<data:NhomMonHocDataSource ID="MaNhomMonNhomMonHocDataSource" runat="server" SelectMethod="GetAll"  />
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNhomMonHoc" runat="server" Text="Nhom Mon Hoc:" AssociatedControlID="dataNhomMonHoc" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNhomMonHoc" Text='<%# Bind("NhomMonHoc") %>'  TextMode="MultiLine"  Width="250px" Rows="5"></asp:TextBox>
				</td>
			</tr>
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
        <td class="literal"><asp:Label ID="lbldataMaHocHam" runat="server" Text="Ma Hoc Ham:" AssociatedControlID="dataMaHocHam" /></td>
        <td>
					<data:EntityDropDownList runat="server" ID="dataMaHocHam" DataSourceID="MaHocHamHocHamDataSource" DataTextField="MaQuanLy" DataValueField="MaHocHam" SelectedValue='<%# Bind("MaHocHam") %>' AppendNullItem="true" Required="false" NullItemText="< Please Choose ...>" />
					<data:HocHamDataSource ID="MaHocHamHocHamDataSource" runat="server" SelectMethod="GetAll"  />
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaHocVi" runat="server" Text="Ma Hoc Vi:" AssociatedControlID="dataMaHocVi" /></td>
        <td>
					<data:EntityDropDownList runat="server" ID="dataMaHocVi" DataSourceID="MaHocViHocViDataSource" DataTextField="MaQuanLy" DataValueField="MaHocVi" SelectedValue='<%# Bind("MaHocVi") %>' AppendNullItem="true" Required="false" NullItemText="< Please Choose ...>" />
					<data:HocViDataSource ID="MaHocViHocViDataSource" runat="server" SelectMethod="GetAll"  />
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaQuanLy" runat="server" Text="Ma Quan Ly:" AssociatedControlID="dataMaQuanLy" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaQuanLy" Text='<%# Bind("MaQuanLy") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaLoaiGiangVien" runat="server" Text="Ma Loai Giang Vien:" AssociatedControlID="dataMaLoaiGiangVien" /></td>
        <td>
					<data:EntityDropDownList runat="server" ID="dataMaLoaiGiangVien" DataSourceID="MaLoaiGiangVienLoaiGiangVienDataSource" DataTextField="MaQuanLy" DataValueField="MaLoaiGiangVien" SelectedValue='<%# Bind("MaLoaiGiangVien") %>' AppendNullItem="true" Required="false" NullItemText="< Please Choose ...>" />
					<data:LoaiGiangVienDataSource ID="MaLoaiGiangVienLoaiGiangVienDataSource" runat="server" SelectMethod="GetAll"  />
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataDonGia" runat="server" Text="Don Gia:" AssociatedControlID="dataDonGia" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataDonGia" Text='<%# Bind("DonGia") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataDonGia" runat="server" Display="Dynamic" ControlToValidate="dataDonGia" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataDonGiaClc" runat="server" Text="Don Gia Clc:" AssociatedControlID="dataDonGiaClc" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataDonGiaClc" Text='<%# Bind("DonGiaClc") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataDonGiaClc" runat="server" Display="Dynamic" ControlToValidate="dataDonGiaClc" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataHeSoQuyDoiChatLuong" runat="server" Text="He So Quy Doi Chat Luong:" AssociatedControlID="dataHeSoQuyDoiChatLuong" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHeSoQuyDoiChatLuong" Text='<%# Bind("HeSoQuyDoiChatLuong") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataHeSoQuyDoiChatLuong" runat="server" Display="Dynamic" ControlToValidate="dataHeSoQuyDoiChatLuong" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
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
			
		</table>

	</ItemTemplate>
</asp:FormView>


