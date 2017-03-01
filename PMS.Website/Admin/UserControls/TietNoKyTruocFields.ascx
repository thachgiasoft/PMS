<%@ Control Language="C#" ClassName="TietNoKyTruocFields" %>

<asp:FormView ID="FormView1" runat="server">
	<ItemTemplate>
		<table border="0" cellpadding="3" cellspacing="1">
			<tr>
        <td class="literal"><asp:Label ID="lbldataNamHocGoc" runat="server" Text="Nam Hoc Goc:" AssociatedControlID="dataNamHocGoc" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNamHocGoc" Text='<%# Bind("NamHocGoc") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTietNoKhac" runat="server" Text="Tiet No Khac:" AssociatedControlID="dataTietNoKhac" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTietNoKhac" Text='<%# Bind("TietNoKhac") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataTietNoKhac" runat="server" Display="Dynamic" ControlToValidate="dataTietNoKhac" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTietNoNcKh" runat="server" Text="Tiet No Nc Kh:" AssociatedControlID="dataTietNoNcKh" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTietNoNcKh" Text='<%# Bind("TietNoNcKh") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataTietNoNcKh" runat="server" Display="Dynamic" ControlToValidate="dataTietNoNcKh" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataLayTuDong" runat="server" Text="Lay Tu Dong:" AssociatedControlID="dataLayTuDong" /></td>
        <td>
					<asp:RadioButtonList runat="server" ID="dataLayTuDong" SelectedValue='<%# Bind("LayTuDong") %>' RepeatDirection="Horizontal"><asp:ListItem Value="True" Text="Yes" Selected="True"></asp:ListItem><asp:ListItem Value="False" Text="No"></asp:ListItem></asp:RadioButtonList>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataGhiChu" runat="server" Text="Ghi Chu:" AssociatedControlID="dataGhiChu" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataGhiChu" Text='<%# Bind("GhiChu") %>'  TextMode="MultiLine"  Width="250px" Rows="5"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNguoiCapNhat" runat="server" Text="Nguoi Cap Nhat:" AssociatedControlID="dataNguoiCapNhat" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNguoiCapNhat" Text='<%# Bind("NguoiCapNhat") %>' MaxLength="50"></asp:TextBox>
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
        <td class="literal"><asp:Label ID="lbldataMaGiangVien" runat="server" Text="Ma Giang Vien:" AssociatedControlID="dataMaGiangVien" /></td>
        <td>
					<data:EntityDropDownList runat="server" ID="dataMaGiangVien" DataSourceID="MaGiangVienGiangVienDataSource" DataTextField="MaDanToc" DataValueField="MaGiangVien" SelectedValue='<%# Bind("MaGiangVien") %>' AppendNullItem="true" Required="false" NullItemText="< Please Choose ...>" />
					<data:GiangVienDataSource ID="MaGiangVienGiangVienDataSource" runat="server" SelectMethod="GetAll"  />
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNgayCapNhat" runat="server" Text="Ngay Cap Nhat:" AssociatedControlID="dataNgayCapNhat" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNgayCapNhat" Text='<%# Bind("NgayCapNhat") %>' MaxLength="50"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataSoTietNoKyTruoc" runat="server" Text="So Tiet No Ky Truoc:" AssociatedControlID="dataSoTietNoKyTruoc" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataSoTietNoKyTruoc" Text='<%# Bind("SoTietNoKyTruoc") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataSoTietNoKyTruoc" runat="server" Display="Dynamic" ControlToValidate="dataSoTietNoKyTruoc" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			
		</table>

	</ItemTemplate>
</asp:FormView>


