<%@ Control Language="C#" ClassName="TaiKhoanFields" %>

<asp:FormView ID="FormView1" runat="server">
	<ItemTemplate>
		<table border="0" cellpadding="3" cellspacing="1">
			<tr>
        <td class="literal"><asp:Label ID="lbldataResetPassWordGv" runat="server" Text="Reset Pass Word Gv:" AssociatedControlID="dataResetPassWordGv" /></td>
        <td>
					<asp:RadioButtonList runat="server" ID="dataResetPassWordGv" SelectedValue='<%# Bind("ResetPassWordGv") %>' RepeatDirection="Horizontal"><asp:ListItem Value="True" Text="Yes" Selected="True"></asp:ListItem><asp:ListItem Value="False" Text="No"></asp:ListItem></asp:RadioButtonList>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaNhomQuyen" runat="server" Text="Ma Nhom Quyen:" AssociatedControlID="dataMaNhomQuyen" /></td>
        <td>
					<data:EntityDropDownList runat="server" ID="dataMaNhomQuyen" DataSourceID="MaNhomQuyenNhomQuyenDataSource" DataTextField="TenNhomQuyen" DataValueField="MaNhomQuyen" SelectedValue='<%# Bind("MaNhomQuyen") %>' AppendNullItem="true" Required="false" NullItemText="< Please Choose ...>" />
					<data:NhomQuyenDataSource ID="MaNhomQuyenNhomQuyenDataSource" runat="server" SelectMethod="GetAll"  />
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTenDangNhap" runat="server" Text="Ten Dang Nhap:" AssociatedControlID="dataTenDangNhap" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTenDangNhap" Text='<%# Bind("TenDangNhap") %>' MaxLength="15"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMatKhau" runat="server" Text="Mat Khau:" AssociatedControlID="dataMatKhau" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMatKhau" Text='<%# Bind("MatKhau") %>' MaxLength="50"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataHoTen" runat="server" Text="Ho Ten:" AssociatedControlID="dataHoTen" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHoTen" Text='<%# Bind("HoTen") %>' MaxLength="50"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTenMayTinh" runat="server" Text="Ten May Tinh:" AssociatedControlID="dataTenMayTinh" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTenMayTinh" Text='<%# Bind("TenMayTinh") %>' MaxLength="100"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataDuongDan" runat="server" Text="Duong Dan:" AssociatedControlID="dataDuongDan" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataDuongDan" Text='<%# Bind("DuongDan") %>' MaxLength="200"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataPhienBan" runat="server" Text="Phien Ban:" AssociatedControlID="dataPhienBan" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataPhienBan" Text='<%# Bind("PhienBan") %>' MaxLength="100"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNgayDangNhap" runat="server" Text="Ngay Dang Nhap:" AssociatedControlID="dataNgayDangNhap" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNgayDangNhap" Text='<%# Bind("NgayDangNhap", "{0:d}") %>' MaxLength="10"></asp:TextBox><asp:ImageButton ID="cal_dataNgayDangNhap" runat="server" SkinID="CalendarImageButton" OnClientClick="javascript:showCalendarControl(this.previousSibling);return false;" />
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTrangThai" runat="server" Text="Trang Thai:" AssociatedControlID="dataTrangThai" /></td>
        <td>
					<asp:RadioButtonList runat="server" ID="dataTrangThai" SelectedValue='<%# Bind("TrangThai") %>' RepeatDirection="Horizontal"><asp:ListItem Value="True" Text="Yes" Selected="True"></asp:ListItem><asp:ListItem Value="False" Text="No"></asp:ListItem></asp:RadioButtonList>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataSkinName" runat="server" Text="Skin Name:" AssociatedControlID="dataSkinName" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataSkinName" Text='<%# Bind("SkinName") %>' MaxLength="100"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNgayTao" runat="server" Text="Ngay Tao:" AssociatedControlID="dataNgayTao" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNgayTao" Text='<%# Bind("NgayTao", "{0:d}") %>' MaxLength="10"></asp:TextBox><asp:ImageButton ID="cal_dataNgayTao" runat="server" SkinID="CalendarImageButton" OnClientClick="javascript:showCalendarControl(this.previousSibling);return false;" />
				</td>
			</tr>
			<tr>
				<td valign="top" class="literal">Tai Khoan:</td>
				<td>
					<asp:CheckBoxList ID="TaiKhoanList" runat="server"
						DataSourceID="TaiKhoanReferenceDataSource"
						DataTextField="TenDangNhap"
						DataValueField="MaTaiKhoan"
						RepeatColumns="4"
					/>				
					<data:TaiKhoanDataSource ID="TaiKhoanReferenceDataSource" runat="server" SelectMethod="GetAll"/>
					
					<data:HeThongDataSource ID="HeThongDataSource" runat="server" SelectMethod="GetByUserId" >
						<Parameters>							
							<asp:QueryStringParameter Name="UserId" QueryStringField="MaTaiKhoan" Type="String" />
						</Parameters>
					</data:HeThongDataSource>	
					
					<data:ManyToManyListRelationship ID="HeThongRelationship" runat="server">
						<PrimaryMember runat="server" DataSourceID="TaiKhoanDataSource" EntityKeyName="MaTaiKhoan" />
						<LinkMember runat="server" DataSourceID="HeThongDataSource" EntityKeyName="UserId" ForeignKeyName="ParentId" />
						<ReferenceMember runat="server" DataSourceID="TaiKhoanReferenceDataSource" ListControlID="TaiKhoanList" EntityKeyName="MaTaiKhoan" />
					</data:ManyToManyListRelationship>					
				</td>
			</tr>			
			
		</table>

	</ItemTemplate>
</asp:FormView>


