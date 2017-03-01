<%@ Control Language="C#" ClassName="KhoiLuongGiangDayCaoDangFields" %>

<asp:FormView ID="FormView1" runat="server">
	<ItemTemplate>
		<table border="0" cellpadding="3" cellspacing="1">
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaGiangVienQuanLy" runat="server" Text="Ma Giang Vien Quan Ly:" AssociatedControlID="dataMaGiangVienQuanLy" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaGiangVienQuanLy" Text='<%# Bind("MaGiangVienQuanLy") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaLopHocPhan" runat="server" Text="Ma Lop Hoc Phan:" AssociatedControlID="dataMaLopHocPhan" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaLopHocPhan" Text='<%# Bind("MaLopHocPhan") %>' MaxLength="30"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataSiSoLop" runat="server" Text="Si So Lop:" AssociatedControlID="dataSiSoLop" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataSiSoLop" Text='<%# Bind("SiSoLop") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataSiSoLop" runat="server" Display="Dynamic" ControlToValidate="dataSiSoLop" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaMonHoc" runat="server" Text="Ma Mon Hoc:" AssociatedControlID="dataMaMonHoc" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaMonHoc" Text='<%# Bind("MaMonHoc") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTietThucDayLt" runat="server" Text="Tiet Thuc Day Lt:" AssociatedControlID="dataTietThucDayLt" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTietThucDayLt" Text='<%# Bind("TietThucDayLt") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataTietThucDayLt" runat="server" Display="Dynamic" ControlToValidate="dataTietThucDayLt" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTietThucDayTh" runat="server" Text="Tiet Thuc Day Th:" AssociatedControlID="dataTietThucDayTh" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTietThucDayTh" Text='<%# Bind("TietThucDayTh") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataTietThucDayTh" runat="server" Display="Dynamic" ControlToValidate="dataTietThucDayTh" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaCauHinhChotGio" runat="server" Text="Ma Cau Hinh Chot Gio:" AssociatedControlID="dataMaCauHinhChotGio" /></td>
        <td>
					<data:EntityDropDownList runat="server" ID="dataMaCauHinhChotGio" DataSourceID="MaCauHinhChotGioCauHinhChotGioDataSource" DataTextField="MaQuanLy" DataValueField="MaCauHinhChotGio" SelectedValue='<%# Bind("MaCauHinhChotGio") %>' AppendNullItem="true" Required="false" NullItemText="< Please Choose ...>" />
					<data:CauHinhChotGioDataSource ID="MaCauHinhChotGioCauHinhChotGioDataSource" runat="server" SelectMethod="GetAll"  />
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTenLopHocPhan" runat="server" Text="Ten Lop Hoc Phan:" AssociatedControlID="dataTenLopHocPhan" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTenLopHocPhan" Text='<%# Bind("TenLopHocPhan") %>'  TextMode="MultiLine"  Width="250px" Rows="5"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaLoaiGiangVien" runat="server" Text="Ma Loai Giang Vien:" AssociatedControlID="dataMaLoaiGiangVien" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaLoaiGiangVien" Text='<%# Bind("MaLoaiGiangVien") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataMaLoaiGiangVien" runat="server" Display="Dynamic" ControlToValidate="dataMaLoaiGiangVien" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaHocHam" runat="server" Text="Ma Hoc Ham:" AssociatedControlID="dataMaHocHam" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaHocHam" Text='<%# Bind("MaHocHam") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataMaHocHam" runat="server" Display="Dynamic" ControlToValidate="dataMaHocHam" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaHocVi" runat="server" Text="Ma Hoc Vi:" AssociatedControlID="dataMaHocVi" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaHocVi" Text='<%# Bind("MaHocVi") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataMaHocVi" runat="server" Display="Dynamic" ControlToValidate="dataMaHocVi" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			
		</table>

	</ItemTemplate>
</asp:FormView>


