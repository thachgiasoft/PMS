<%@ Control Language="C#" ClassName="DinhMucGioChuanToiThieuTheoChucVuFields" %>

<asp:FormView ID="FormView1" runat="server">
	<ItemTemplate>
		<table border="0" cellpadding="3" cellspacing="1">
			<tr>
        <td class="literal"><asp:Label ID="lbldataSoTietNghiaVu" runat="server" Text="So Tiet Nghia Vu:" AssociatedControlID="dataSoTietNghiaVu" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataSoTietNghiaVu" Text='<%# Bind("SoTietNghiaVu") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataSoTietNghiaVu" runat="server" Display="Dynamic" ControlToValidate="dataSoTietNghiaVu" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNguoiCapNhat" runat="server" Text="Nguoi Cap Nhat:" AssociatedControlID="dataNguoiCapNhat" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNguoiCapNhat" Text='<%# Bind("NguoiCapNhat") %>' MaxLength="50"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataIdQuyMo" runat="server" Text="Id Quy Mo:" AssociatedControlID="dataIdQuyMo" /></td>
        <td>
					<data:EntityDropDownList runat="server" ID="dataIdQuyMo" DataSourceID="IdQuyMoDanhMucQuyMoDataSource" DataTextField="MaQuyMo" DataValueField="Id" SelectedValue='<%# Bind("IdQuyMo") %>' AppendNullItem="true" Required="false" NullItemText="< Please Choose ...>" />
					<data:DanhMucQuyMoDataSource ID="IdQuyMoDanhMucQuyMoDataSource" runat="server" SelectMethod="GetAll"  />
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNhomGiangVien" runat="server" Text="Nhom Giang Vien:" AssociatedControlID="dataNhomGiangVien" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNhomGiangVien" Text='<%# Bind("NhomGiangVien") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataNhomGiangVien" runat="server" Display="Dynamic" ControlToValidate="dataNhomGiangVien" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNgayCapNhat" runat="server" Text="Ngay Cap Nhat:" AssociatedControlID="dataNgayCapNhat" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNgayCapNhat" Text='<%# Bind("NgayCapNhat") %>' MaxLength="50"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataPhanTramGiamTru" runat="server" Text="Phan Tram Giam Tru:" AssociatedControlID="dataPhanTramGiamTru" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataPhanTramGiamTru" Text='<%# Bind("PhanTramGiamTru") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataPhanTramGiamTru" runat="server" Display="Dynamic" ControlToValidate="dataPhanTramGiamTru" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaChucVu" runat="server" Text="Ma Chuc Vu:" AssociatedControlID="dataMaChucVu" /></td>
        <td>
					<data:EntityDropDownList runat="server" ID="dataMaChucVu" DataSourceID="MaChucVuChucVuDataSource" DataTextField="MaQuanLy" DataValueField="MaChucVu" SelectedValue='<%# Bind("MaChucVu") %>' AppendNullItem="true" Required="false" NullItemText="< Please Choose ...>" />
					<data:ChucVuDataSource ID="MaChucVuChucVuDataSource" runat="server" SelectMethod="GetAll"  />
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
			
		</table>

	</ItemTemplate>
</asp:FormView>


