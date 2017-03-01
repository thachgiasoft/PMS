<%@ Control Language="C#" ClassName="CauHinhFields" %>

<asp:FormView ID="FormView1" runat="server">
	<ItemTemplate>
		<table border="0" cellpadding="3" cellspacing="1">
			<tr>
        <td class="literal"><asp:Label ID="lbldataChucVuKeToan" runat="server" Text="Chuc Vu Ke Toan:" AssociatedControlID="dataChucVuKeToan" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataChucVuKeToan" Text='<%# Bind("ChucVuKeToan") %>' MaxLength="100"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataChucVuDaoTao" runat="server" Text="Chuc Vu Dao Tao:" AssociatedControlID="dataChucVuDaoTao" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataChucVuDaoTao" Text='<%# Bind("ChucVuDaoTao") %>' MaxLength="100"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataChucVuDaiDienHopDongThinhGiang" runat="server" Text="Chuc Vu Dai Dien Hop Dong Thinh Giang:" AssociatedControlID="dataChucVuDaiDienHopDongThinhGiang" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataChucVuDaiDienHopDongThinhGiang" Text='<%# Bind("ChucVuDaiDienHopDongThinhGiang") %>' MaxLength="100"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataChucVuDaiDienHopDongThinhGiang02" runat="server" Text="Chuc Vu Dai Dien Hop Dong Thinh Giang02:" AssociatedControlID="dataChucVuDaiDienHopDongThinhGiang02" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataChucVuDaiDienHopDongThinhGiang02" Text='<%# Bind("ChucVuDaiDienHopDongThinhGiang02") %>' MaxLength="100"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataDiaChiDaiDien" runat="server" Text="Dia Chi Dai Dien:" AssociatedControlID="dataDiaChiDaiDien" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataDiaChiDaiDien" Text='<%# Bind("DiaChiDaiDien") %>' MaxLength="200"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataChucVuKhoa" runat="server" Text="Chuc Vu Khoa:" AssociatedControlID="dataChucVuKhoa" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataChucVuKhoa" Text='<%# Bind("ChucVuKhoa") %>' MaxLength="100"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataChucVuToChucCanBo" runat="server" Text="Chuc Vu To Chuc Can Bo:" AssociatedControlID="dataChucVuToChucCanBo" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataChucVuToChucCanBo" Text='<%# Bind("ChucVuToChucCanBo") %>' MaxLength="100"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataDienThoaiDaiDien" runat="server" Text="Dien Thoai Dai Dien:" AssociatedControlID="dataDienThoaiDaiDien" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataDienThoaiDaiDien" Text='<%# Bind("DienThoaiDaiDien") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataFaxDaiDien" runat="server" Text="Fax Dai Dien:" AssociatedControlID="dataFaxDaiDien" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataFaxDaiDien" Text='<%# Bind("FaxDaiDien") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataChucVuKeHoachTaiChinh" runat="server" Text="Chuc Vu Ke Hoach Tai Chinh:" AssociatedControlID="dataChucVuKeHoachTaiChinh" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataChucVuKeHoachTaiChinh" Text='<%# Bind("ChucVuKeHoachTaiChinh") %>' MaxLength="100"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataDaiDienHopDongThinhGiang" runat="server" Text="Dai Dien Hop Dong Thinh Giang:" AssociatedControlID="dataDaiDienHopDongThinhGiang" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataDaiDienHopDongThinhGiang" Text='<%# Bind("DaiDienHopDongThinhGiang") %>' MaxLength="100"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataChucVuBanGiamHieu" runat="server" Text="Chuc Vu Ban Giam Hieu:" AssociatedControlID="dataChucVuBanGiamHieu" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataChucVuBanGiamHieu" Text='<%# Bind("ChucVuBanGiamHieu") %>' MaxLength="100"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTenTruong" runat="server" Text="Ten Truong:" AssociatedControlID="dataTenTruong" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTenTruong" Text='<%# Bind("TenTruong") %>' MaxLength="200"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataPhongDaoTao" runat="server" Text="Phong Dao Tao:" AssociatedControlID="dataPhongDaoTao" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataPhongDaoTao" Text='<%# Bind("PhongDaoTao") %>' MaxLength="200"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNguoiLapbieu" runat="server" Text="Nguoi Lapbieu:" AssociatedControlID="dataNguoiLapbieu" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNguoiLapbieu" Text='<%# Bind("NguoiLapbieu") %>' MaxLength="200"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTrangThai" runat="server" Text="Trang Thai:" AssociatedControlID="dataTrangThai" /></td>
        <td>
					<asp:RadioButtonList runat="server" ID="dataTrangThai" SelectedValue='<%# Bind("TrangThai") %>' RepeatDirection="Horizontal"><asp:ListItem Value="True" Text="Yes" Selected="True"></asp:ListItem><asp:ListItem Value="False" Text="No"></asp:ListItem></asp:RadioButtonList>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataPhongToChucCanBo" runat="server" Text="Phong To Chuc Can Bo:" AssociatedControlID="dataPhongToChucCanBo" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataPhongToChucCanBo" Text='<%# Bind("PhongToChucCanBo") %>' MaxLength="200"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataPhongKeHoachTaiChinh" runat="server" Text="Phong Ke Hoach Tai Chinh:" AssociatedControlID="dataPhongKeHoachTaiChinh" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataPhongKeHoachTaiChinh" Text='<%# Bind("PhongKeHoachTaiChinh") %>' MaxLength="200"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataBanGiamHieu" runat="server" Text="Ban Giam Hieu:" AssociatedControlID="dataBanGiamHieu" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataBanGiamHieu" Text='<%# Bind("BanGiamHieu") %>' MaxLength="200"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataKeToan" runat="server" Text="Ke Toan:" AssociatedControlID="dataKeToan" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataKeToan" Text='<%# Bind("KeToan") %>' MaxLength="200"></asp:TextBox>
				</td>
			</tr>
			
		</table>

	</ItemTemplate>
</asp:FormView>


