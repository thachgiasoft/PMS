<%@ Control Language="C#" ClassName="QuyDinhTienCanTrenFields" %>

<asp:FormView ID="FormView1" runat="server">
	<ItemTemplate>
		<table border="0" cellpadding="3" cellspacing="1">
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaLoaiNhanVien" runat="server" Text="Ma Loai Nhan Vien:" AssociatedControlID="dataMaLoaiNhanVien" /></td>
        <td>
					<data:EntityDropDownList runat="server" ID="dataMaLoaiNhanVien" DataSourceID="MaLoaiNhanVienLoaiNhanVienDataSource" DataTextField="MaQuanLy" DataValueField="MaLoaiNhanVien" SelectedValue='<%# Bind("MaLoaiNhanVien") %>' AppendNullItem="true" Required="false" NullItemText="< Please Choose ...>" />
					<data:LoaiNhanVienDataSource ID="MaLoaiNhanVienLoaiNhanVienDataSource" runat="server" SelectMethod="GetAll"  />
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
        <td class="literal"><asp:Label ID="lbldataTienCanTren" runat="server" Text="Tien Can Tren:" AssociatedControlID="dataTienCanTren" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTienCanTren" Text='<%# Bind("TienCanTren") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataTienCanTren" runat="server" Display="Dynamic" ControlToValidate="dataTienCanTren" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
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
        <td class="literal"><asp:Label ID="lbldataNamHoc" runat="server" Text="Nam Hoc:" AssociatedControlID="dataNamHoc" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNamHoc" Text='<%# Bind("NamHoc") %>' MaxLength="10"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataStt" runat="server" Text="Stt:" AssociatedControlID="dataStt" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataStt" Text='<%# Bind("Stt") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataStt" runat="server" Display="Dynamic" ControlToValidate="dataStt" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
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
        <td class="literal"><asp:Label ID="lbldataHocKy" runat="server" Text="Hoc Ky:" AssociatedControlID="dataHocKy" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHocKy" Text='<%# Bind("HocKy") %>' MaxLength="10"></asp:TextBox>
				</td>
			</tr>
			
		</table>

	</ItemTemplate>
</asp:FormView>


