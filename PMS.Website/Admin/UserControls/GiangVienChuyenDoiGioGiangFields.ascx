<%@ Control Language="C#" ClassName="GiangVienChuyenDoiGioGiangFields" %>

<asp:FormView ID="FormView1" runat="server">
	<ItemTemplate>
		<table border="0" cellpadding="3" cellspacing="1">
			<tr>
        <td class="literal"><asp:Label ID="lbldataSoTietGiangChuyenSangNckh" runat="server" Text="So Tiet Giang Chuyen Sang Nckh:" AssociatedControlID="dataSoTietGiangChuyenSangNckh" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataSoTietGiangChuyenSangNckh" Text='<%# Bind("SoTietGiangChuyenSangNckh") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataSoTietGiangChuyenSangNckh" runat="server" Display="Dynamic" ControlToValidate="dataSoTietGiangChuyenSangNckh" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataSoTietNckhChuyenSangGiangDay" runat="server" Text="So Tiet Nckh Chuyen Sang Giang Day:" AssociatedControlID="dataSoTietNckhChuyenSangGiangDay" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataSoTietNckhChuyenSangGiangDay" Text='<%# Bind("SoTietNckhChuyenSangGiangDay") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataSoTietNckhChuyenSangGiangDay" runat="server" Display="Dynamic" ControlToValidate="dataSoTietNckhChuyenSangGiangDay" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataGhiChu" runat="server" Text="Ghi Chu:" AssociatedControlID="dataGhiChu" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataGhiChu" Text='<%# Bind("GhiChu") %>'  TextMode="MultiLine"  Width="250px" Rows="5"></asp:TextBox>
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
        <td class="literal"><asp:Label ID="lbldataMaGiangVien" runat="server" Text="Ma Giang Vien:" AssociatedControlID="dataMaGiangVien" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaGiangVien" Text='<%# Bind("MaGiangVien") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataMaGiangVien" runat="server" Display="Dynamic" ControlToValidate="dataMaGiangVien" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			
		</table>

	</ItemTemplate>
</asp:FormView>


