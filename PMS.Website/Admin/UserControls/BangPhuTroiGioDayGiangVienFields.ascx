<%@ Control Language="C#" ClassName="BangPhuTroiGioDayGiangVienFields" %>

<asp:FormView ID="FormView1" runat="server">
	<ItemTemplate>
		<table border="0" cellpadding="3" cellspacing="1">
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaGiangVien" runat="server" Text="Ma Giang Vien:" AssociatedControlID="dataMaGiangVien" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaGiangVien" Text='<%# Bind("MaGiangVien") %>'></asp:TextBox><asp:RequiredFieldValidator ID="ReqVal_dataMaGiangVien" runat="server" Display="Dynamic" ControlToValidate="dataMaGiangVien" ErrorMessage="Required"></asp:RequiredFieldValidator><asp:RangeValidator ID="RangeVal_dataMaGiangVien" runat="server" Display="Dynamic" ControlToValidate="dataMaGiangVien" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaQuanLy" runat="server" Text="Ma Quan Ly:" AssociatedControlID="dataMaQuanLy" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaQuanLy" Text='<%# Bind("MaQuanLy") %>' MaxLength="20"></asp:TextBox><asp:RequiredFieldValidator ID="ReqVal_dataMaQuanLy" runat="server" Display="Dynamic" ControlToValidate="dataMaQuanLy" ErrorMessage="Required"></asp:RequiredFieldValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataHo" runat="server" Text="Ho:" AssociatedControlID="dataHo" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHo" Text='<%# Bind("Ho") %>' MaxLength="101"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTen" runat="server" Text="Ten:" AssociatedControlID="dataTen" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTen" Text='<%# Bind("Ten") %>' MaxLength="50"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNamHoc" runat="server" Text="Nam Hoc:" AssociatedControlID="dataNamHoc" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNamHoc" Text='<%# Bind("NamHoc") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaDonVi" runat="server" Text="Ma Don Vi:" AssociatedControlID="dataMaDonVi" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaDonVi" Text='<%# Bind("MaDonVi") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTenDonVi" runat="server" Text="Ten Don Vi:" AssociatedControlID="dataTenDonVi" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTenDonVi" Text='<%# Bind("TenDonVi") %>'  TextMode="MultiLine"  Width="250px" Rows="5"></asp:TextBox><asp:RequiredFieldValidator ID="ReqVal_dataTenDonVi" runat="server" Display="Dynamic" ControlToValidate="dataTenDonVi" ErrorMessage="Required"></asp:RequiredFieldValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaLoaiGiangVien" runat="server" Text="Ma Loai Giang Vien:" AssociatedControlID="dataMaLoaiGiangVien" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaLoaiGiangVien" Text='<%# Bind("MaLoaiGiangVien") %>'></asp:TextBox><asp:RequiredFieldValidator ID="ReqVal_dataMaLoaiGiangVien" runat="server" Display="Dynamic" ControlToValidate="dataMaLoaiGiangVien" ErrorMessage="Required"></asp:RequiredFieldValidator><asp:RangeValidator ID="RangeVal_dataMaLoaiGiangVien" runat="server" Display="Dynamic" ControlToValidate="dataMaLoaiGiangVien" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTenLoaiGiangVien" runat="server" Text="Ten Loai Giang Vien:" AssociatedControlID="dataTenLoaiGiangVien" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTenLoaiGiangVien" Text='<%# Bind("TenLoaiGiangVien") %>' MaxLength="100"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTcThucDay" runat="server" Text="Tc Thuc Day:" AssociatedControlID="dataTcThucDay" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTcThucDay" Text='<%# Bind("TcThucDay") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataTcThucDay" runat="server" Display="Dynamic" ControlToValidate="dataTcThucDay" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTietQd" runat="server" Text="Tiet Qd:" AssociatedControlID="dataTietQd" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTietQd" Text='<%# Bind("TietQd") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataTietQd" runat="server" Display="Dynamic" ControlToValidate="dataTietQd" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNhiemVuGd" runat="server" Text="Nhiem Vu Gd:" AssociatedControlID="dataNhiemVuGd" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNhiemVuGd" Text='<%# Bind("NhiemVuGd") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataNhiemVuGd" runat="server" Display="Dynamic" ControlToValidate="dataNhiemVuGd" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNhiemVuNckh" runat="server" Text="Nhiem Vu Nckh:" AssociatedControlID="dataNhiemVuNckh" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNhiemVuNckh" Text='<%# Bind("NhiemVuNckh") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataNhiemVuNckh" runat="server" Display="Dynamic" ControlToValidate="dataNhiemVuNckh" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataPhanCongCn" runat="server" Text="Phan Cong Cn:" AssociatedControlID="dataPhanCongCn" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataPhanCongCn" Text='<%# Bind("PhanCongCn") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataPhanCongCn" runat="server" Display="Dynamic" ControlToValidate="dataPhanCongCn" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataCongTrinhCd" runat="server" Text="Cong Trinh Cd:" AssociatedControlID="dataCongTrinhCd" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataCongTrinhCd" Text='<%# Bind("CongTrinhCd") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataCongTrinhCd" runat="server" Display="Dynamic" ControlToValidate="dataCongTrinhCd" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataCongTrinhTc" runat="server" Text="Cong Trinh Tc:" AssociatedControlID="dataCongTrinhTc" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataCongTrinhTc" Text='<%# Bind("CongTrinhTc") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataCongTrinhTc" runat="server" Display="Dynamic" ControlToValidate="dataCongTrinhTc" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			
		</table>

	</ItemTemplate>
</asp:FormView>


