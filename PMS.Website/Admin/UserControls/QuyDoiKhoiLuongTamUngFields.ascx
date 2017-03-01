<%@ Control Language="C#" ClassName="QuyDoiKhoiLuongTamUngFields" %>

<asp:FormView ID="FormView1" runat="server">
	<ItemTemplate>
		<table border="0" cellpadding="3" cellspacing="1">
			<tr>
        <td class="literal"><asp:Label ID="lbldataHeSoTroCap" runat="server" Text="He So Tro Cap:" AssociatedControlID="dataHeSoTroCap" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHeSoTroCap" Text='<%# Bind("HeSoTroCap") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataHeSoTroCap" runat="server" Display="Dynamic" ControlToValidate="dataHeSoTroCap" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataHeSoLuong" runat="server" Text="He So Luong:" AssociatedControlID="dataHeSoLuong" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHeSoLuong" Text='<%# Bind("HeSoLuong") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataHeSoLuong" runat="server" Display="Dynamic" ControlToValidate="dataHeSoLuong" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataHeSoThinhGiangMonChuyenNganh" runat="server" Text="He So Thinh Giang Mon Chuyen Nganh:" AssociatedControlID="dataHeSoThinhGiangMonChuyenNganh" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHeSoThinhGiangMonChuyenNganh" Text='<%# Bind("HeSoThinhGiangMonChuyenNganh") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataHeSoThinhGiangMonChuyenNganh" runat="server" Display="Dynamic" ControlToValidate="dataHeSoThinhGiangMonChuyenNganh" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataLoaiLop" runat="server" Text="Loai Lop:" AssociatedControlID="dataLoaiLop" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataLoaiLop" Text='<%# Bind("LoaiLop") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataHeSoClcCntn" runat="server" Text="He So Clc Cntn:" AssociatedControlID="dataHeSoClcCntn" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHeSoClcCntn" Text='<%# Bind("HeSoClcCntn") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataHeSoClcCntn" runat="server" Display="Dynamic" ControlToValidate="dataHeSoClcCntn" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataChot" runat="server" Text="Chot:" AssociatedControlID="dataChot" /></td>
        <td>
					<asp:RadioButtonList runat="server" ID="dataChot" SelectedValue='<%# Bind("Chot") %>' RepeatDirection="Horizontal"><asp:ListItem Value="True" Text="Yes" Selected="True"></asp:ListItem><asp:ListItem Value="False" Text="No"></asp:ListItem></asp:RadioButtonList>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMucThanhToan" runat="server" Text="Muc Thanh Toan:" AssociatedControlID="dataMucThanhToan" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMucThanhToan" Text='<%# Bind("MucThanhToan") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataMucThanhToan" runat="server" Display="Dynamic" ControlToValidate="dataMucThanhToan" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataGhiChu" runat="server" Text="Ghi Chu:" AssociatedControlID="dataGhiChu" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataGhiChu" Text='<%# Bind("GhiChu") %>'  TextMode="MultiLine"  Width="250px" Rows="5"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataHeSoMonMoi" runat="server" Text="He So Mon Moi:" AssociatedControlID="dataHeSoMonMoi" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHeSoMonMoi" Text='<%# Bind("HeSoMonMoi") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataHeSoMonMoi" runat="server" Display="Dynamic" ControlToValidate="dataHeSoMonMoi" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataHeSoNienCheTinChi" runat="server" Text="He So Nien Che Tin Chi:" AssociatedControlID="dataHeSoNienCheTinChi" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHeSoNienCheTinChi" Text='<%# Bind("HeSoNienCheTinChi") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataHeSoNienCheTinChi" runat="server" Display="Dynamic" ControlToValidate="dataHeSoNienCheTinChi" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataHeSoNgoaiGio" runat="server" Text="He So Ngoai Gio:" AssociatedControlID="dataHeSoNgoaiGio" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHeSoNgoaiGio" Text='<%# Bind("HeSoNgoaiGio") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataHeSoNgoaiGio" runat="server" Display="Dynamic" ControlToValidate="dataHeSoNgoaiGio" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataHeSoNgonNgu" runat="server" Text="He So Ngon Ngu:" AssociatedControlID="dataHeSoNgonNgu" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHeSoNgonNgu" Text='<%# Bind("HeSoNgonNgu") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataHeSoNgonNgu" runat="server" Display="Dynamic" ControlToValidate="dataHeSoNgonNgu" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataHeSoChucDanhChuyenMon" runat="server" Text="He So Chuc Danh Chuyen Mon:" AssociatedControlID="dataHeSoChucDanhChuyenMon" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHeSoChucDanhChuyenMon" Text='<%# Bind("HeSoChucDanhChuyenMon") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataHeSoChucDanhChuyenMon" runat="server" Display="Dynamic" ControlToValidate="dataHeSoChucDanhChuyenMon" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataHeSoBacDaoTao" runat="server" Text="He So Bac Dao Tao:" AssociatedControlID="dataHeSoBacDaoTao" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHeSoBacDaoTao" Text='<%# Bind("HeSoBacDaoTao") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataHeSoBacDaoTao" runat="server" Display="Dynamic" ControlToValidate="dataHeSoBacDaoTao" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaKhoiLuongTamUng" runat="server" Text="Ma Khoi Luong Tam Ung:" AssociatedControlID="dataMaKhoiLuongTamUng" /></td>
        <td>
					<data:EntityDropDownList runat="server" ID="dataMaKhoiLuongTamUng" DataSourceID="MaKhoiLuongTamUngKhoiLuongTamUngDataSource" DataTextField="MaLichHoc" DataValueField="MaKhoiLuong" SelectedValue='<%# Bind("MaKhoiLuongTamUng") %>' AppendNullItem="true" Required="false" NullItemText="< Please Choose ...>" />
					<data:KhoiLuongTamUngDataSource ID="MaKhoiLuongTamUngKhoiLuongTamUngDataSource" runat="server" SelectMethod="GetAll"  />
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataHeSoCongViec" runat="server" Text="He So Cong Viec:" AssociatedControlID="dataHeSoCongViec" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHeSoCongViec" Text='<%# Bind("HeSoCongViec") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataHeSoCongViec" runat="server" Display="Dynamic" ControlToValidate="dataHeSoCongViec" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTietQuyDoi" runat="server" Text="Tiet Quy Doi:" AssociatedControlID="dataTietQuyDoi" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTietQuyDoi" Text='<%# Bind("TietQuyDoi") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataTietQuyDoi" runat="server" Display="Dynamic" ControlToValidate="dataTietQuyDoi" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataHeSoQuyDoiThucHanhSangLyThuyet" runat="server" Text="He So Quy Doi Thuc Hanh Sang Ly Thuyet:" AssociatedControlID="dataHeSoQuyDoiThucHanhSangLyThuyet" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHeSoQuyDoiThucHanhSangLyThuyet" Text='<%# Bind("HeSoQuyDoiThucHanhSangLyThuyet") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataHeSoQuyDoiThucHanhSangLyThuyet" runat="server" Display="Dynamic" ControlToValidate="dataHeSoQuyDoiThucHanhSangLyThuyet" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataSoTietThucTeQuyDoi" runat="server" Text="So Tiet Thuc Te Quy Doi:" AssociatedControlID="dataSoTietThucTeQuyDoi" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataSoTietThucTeQuyDoi" Text='<%# Bind("SoTietThucTeQuyDoi") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataSoTietThucTeQuyDoi" runat="server" Display="Dynamic" ControlToValidate="dataSoTietThucTeQuyDoi" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataHeSoLopDong" runat="server" Text="He So Lop Dong:" AssociatedControlID="dataHeSoLopDong" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHeSoLopDong" Text='<%# Bind("HeSoLopDong") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataHeSoLopDong" runat="server" Display="Dynamic" ControlToValidate="dataHeSoLopDong" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataHeSoCoSo" runat="server" Text="He So Co So:" AssociatedControlID="dataHeSoCoSo" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHeSoCoSo" Text='<%# Bind("HeSoCoSo") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataHeSoCoSo" runat="server" Display="Dynamic" ControlToValidate="dataHeSoCoSo" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			
		</table>

	</ItemTemplate>
</asp:FormView>


