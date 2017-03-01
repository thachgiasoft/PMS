<%@ Control Language="C#" ClassName="HeSoChucDanhChuyenMonFields" %>

<asp:FormView ID="FormView1" runat="server">
	<ItemTemplate>
		<table border="0" cellpadding="3" cellspacing="1">
			<tr>
        <td class="literal"><asp:Label ID="lbldataNamHoc" runat="server" Text="Nam Hoc:" AssociatedControlID="dataNamHoc" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNamHoc" Text='<%# Bind("NamHoc") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataHeSo" runat="server" Text="He So:" AssociatedControlID="dataHeSo" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHeSo" Text='<%# Bind("HeSo") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataHeSo" runat="server" Display="Dynamic" ControlToValidate="dataHeSo" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataBacDaoTao" runat="server" Text="Bac Dao Tao:" AssociatedControlID="dataBacDaoTao" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataBacDaoTao" Text='<%# Bind("BacDaoTao") %>' MaxLength="200"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataHocKy" runat="server" Text="Hoc Ky:" AssociatedControlID="dataHocKy" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHocKy" Text='<%# Bind("HocKy") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaLoaiGiangVien" runat="server" Text="Ma Loai Giang Vien:" AssociatedControlID="dataMaLoaiGiangVien" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaLoaiGiangVien" Text='<%# Bind("MaLoaiGiangVien") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataMaLoaiGiangVien" runat="server" Display="Dynamic" ControlToValidate="dataMaLoaiGiangVien" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaQuanLy" runat="server" Text="Ma Quan Ly:" AssociatedControlID="dataMaQuanLy" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaQuanLy" Text='<%# Bind("MaQuanLy") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaHocVi" runat="server" Text="Ma Hoc Vi:" AssociatedControlID="dataMaHocVi" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaHocVi" Text='<%# Bind("MaHocVi") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataMaHocVi" runat="server" Display="Dynamic" ControlToValidate="dataMaHocVi" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaHocHam" runat="server" Text="Ma Hoc Ham:" AssociatedControlID="dataMaHocHam" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaHocHam" Text='<%# Bind("MaHocHam") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataMaHocHam" runat="server" Display="Dynamic" ControlToValidate="dataMaHocHam" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			
		</table>

	</ItemTemplate>
</asp:FormView>


