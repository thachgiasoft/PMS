<%@ Control Language="C#" ClassName="ThanhTraGiangDayFields" %>

<asp:FormView ID="FormView1" runat="server">
	<ItemTemplate>
		<table border="0" cellpadding="3" cellspacing="1">
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaHienThi" runat="server" Text="Ma Hien Thi:" AssociatedControlID="dataMaHienThi" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaHienThi" Text='<%# Bind("MaHienThi") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaQuanLy" runat="server" Text="Ma Quan Ly:" AssociatedControlID="dataMaQuanLy" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaQuanLy" Text='<%# Bind("MaQuanLy") %>' MaxLength="152"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataKhoa" runat="server" Text="Khoa:" AssociatedControlID="dataKhoa" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataKhoa" Text='<%# Bind("Khoa") %>' MaxLength="50"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataLoaiGiangVien" runat="server" Text="Loai Giang Vien:" AssociatedControlID="dataLoaiGiangVien" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataLoaiGiangVien" Text='<%# Bind("LoaiGiangVien") %>' MaxLength="10"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTenHocPhan" runat="server" Text="Ten Hoc Phan:" AssociatedControlID="dataTenHocPhan" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTenHocPhan" Text='<%# Bind("TenHocPhan") %>'  TextMode="MultiLine"  Width="250px" Rows="5"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTinhHinhGhiNhan" runat="server" Text="Tinh Hinh Ghi Nhan:" AssociatedControlID="dataTinhHinhGhiNhan" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTinhHinhGhiNhan" Text='<%# Bind("TinhHinhGhiNhan") %>'  TextMode="MultiLine"  Width="250px" Rows="5"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNgay" runat="server" Text="Ngay:" AssociatedControlID="dataNgay" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNgay" Text='<%# Bind("Ngay", "{0:d}") %>' MaxLength="10"></asp:TextBox><asp:ImageButton ID="cal_dataNgay" runat="server" SkinID="CalendarImageButton" OnClientClick="javascript:showCalendarControl(this.previousSibling);return false;" />
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTiet" runat="server" Text="Tiet:" AssociatedControlID="dataTiet" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTiet" Text='<%# Bind("Tiet") %>' MaxLength="10"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataLop" runat="server" Text="Lop:" AssociatedControlID="dataLop" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataLop" Text='<%# Bind("Lop") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataPhong" runat="server" Text="Phong:" AssociatedControlID="dataPhong" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataPhong" Text='<%# Bind("Phong") %>' MaxLength="50"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataThoiDiemGhiNhan" runat="server" Text="Thoi Diem Ghi Nhan:" AssociatedControlID="dataThoiDiemGhiNhan" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataThoiDiemGhiNhan" Text='<%# Bind("ThoiDiemGhiNhan") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataLyDo" runat="server" Text="Ly Do:" AssociatedControlID="dataLyDo" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataLyDo" Text='<%# Bind("LyDo") %>' MaxLength="100"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataGhiChu" runat="server" Text="Ghi Chu:" AssociatedControlID="dataGhiChu" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataGhiChu" Text='<%# Bind("GhiChu") %>' MaxLength="50"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaHinhThucViPham" runat="server" Text="Ma Hinh Thuc Vi Pham:" AssociatedControlID="dataMaHinhThucViPham" /></td>
        <td>
					<asp:HiddenField runat="server" id="dataMaHinhThucViPham" Value='<%# Bind("MaHinhThucViPham") %>'></asp:HiddenField>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataDaBaoSuaTkb" runat="server" Text="Da Bao Sua Tkb:" AssociatedControlID="dataDaBaoSuaTkb" /></td>
        <td>
					<asp:RadioButtonList runat="server" ID="dataDaBaoSuaTkb" SelectedValue='<%# Bind("DaBaoSuaTkb") %>' RepeatDirection="Horizontal"><asp:ListItem Value="True" Text="Yes" Selected="True"></asp:ListItem><asp:ListItem Value="False" Text="No"></asp:ListItem></asp:RadioButtonList>
				</td>
			</tr>
			
		</table>

	</ItemTemplate>
</asp:FormView>


