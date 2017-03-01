<%@ Control Language="C#" ClassName="ChucNangFields" %>

<asp:FormView ID="FormView1" runat="server">
	<ItemTemplate>
		<table border="0" cellpadding="3" cellspacing="1">
			<tr>
        <td class="literal"><asp:Label ID="lbldataParentId" runat="server" Text="Parent Id:" AssociatedControlID="dataParentId" /></td>
        <td>
					<data:EntityDropDownList runat="server" ID="dataParentId" DataSourceID="ParentIdChucNangDataSource" DataTextField="PhanLoai" DataValueField="Id" SelectedValue='<%# Bind("ParentId") %>' AppendNullItem="true" Required="false" NullItemText="< Please Choose ...>" />
					<data:ChucNangDataSource ID="ParentIdChucNangDataSource" runat="server" SelectMethod="GetAll"  />
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataPhanLoai" runat="server" Text="Phan Loai:" AssociatedControlID="dataPhanLoai" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataPhanLoai" Text='<%# Bind("PhanLoai") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMenu" runat="server" Text="Menu:" AssociatedControlID="dataMenu" /></td>
        <td>
					<asp:RadioButtonList runat="server" ID="dataMenu" SelectedValue='<%# Bind("Menu") %>' RepeatDirection="Horizontal"><asp:ListItem Value="True" Text="Yes" Selected="True"></asp:ListItem><asp:ListItem Value="False" Text="No"></asp:ListItem></asp:RadioButtonList>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataBeginGroup" runat="server" Text="Begin Group:" AssociatedControlID="dataBeginGroup" /></td>
        <td>
					<asp:RadioButtonList runat="server" ID="dataBeginGroup" SelectedValue='<%# Bind("BeginGroup") %>' RepeatDirection="Horizontal"><asp:ListItem Value="True" Text="Yes" Selected="True"></asp:ListItem><asp:ListItem Value="False" Text="No"></asp:ListItem></asp:RadioButtonList>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataRibbonStyle" runat="server" Text="Ribbon Style:" AssociatedControlID="dataRibbonStyle" /></td>
        <td>
					<asp:RadioButtonList runat="server" ID="dataRibbonStyle" SelectedValue='<%# Bind("RibbonStyle") %>' RepeatDirection="Horizontal"><asp:ListItem Value="True" Text="Yes" Selected="True"></asp:ListItem><asp:ListItem Value="False" Text="No"></asp:ListItem></asp:RadioButtonList>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataDataLayout" runat="server" Text="Data Layout:" AssociatedControlID="dataDataLayout" /></td>
        <td>
					<asp:HiddenField runat="server" id="dataDataLayout" Value='<%# Bind("DataLayout") %>'></asp:HiddenField>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTenChucNang" runat="server" Text="Ten Chuc Nang:" AssociatedControlID="dataTenChucNang" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTenChucNang" Text='<%# Bind("TenChucNang") %>'  TextMode="MultiLine"  Width="250px" Rows="5"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTenForm" runat="server" Text="Ten Form:" AssociatedControlID="dataTenForm" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTenForm" Text='<%# Bind("TenForm") %>'  TextMode="MultiLine"  Width="250px" Rows="5"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataHinhAnh" runat="server" Text="Hinh Anh:" AssociatedControlID="dataHinhAnh" /></td>
        <td>
					<asp:HiddenField runat="server" id="dataHinhAnh" Value='<%# Bind("HinhAnh") %>'></asp:HiddenField>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataThuTu" runat="server" Text="Thu Tu:" AssociatedControlID="dataThuTu" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataThuTu" Text='<%# Bind("ThuTu") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataThuTu" runat="server" Display="Dynamic" ControlToValidate="dataThuTu" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTenPhuongThuc" runat="server" Text="Ten Phuong Thuc:" AssociatedControlID="dataTenPhuongThuc" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTenPhuongThuc" Text='<%# Bind("TenPhuongThuc") %>' MaxLength="100"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataThamSo" runat="server" Text="Tham So:" AssociatedControlID="dataThamSo" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataThamSo" Text='<%# Bind("ThamSo") %>' MaxLength="100"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataKieuForm" runat="server" Text="Kieu Form:" AssociatedControlID="dataKieuForm" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataKieuForm" Text='<%# Bind("KieuForm") %>' MaxLength="10"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTrangThai" runat="server" Text="Trang Thai:" AssociatedControlID="dataTrangThai" /></td>
        <td>
					<asp:RadioButtonList runat="server" ID="dataTrangThai" SelectedValue='<%# Bind("TrangThai") %>' RepeatDirection="Horizontal"><asp:ListItem Value="True" Text="Yes" Selected="True"></asp:ListItem><asp:ListItem Value="False" Text="No"></asp:ListItem></asp:RadioButtonList>
				</td>
			</tr>
			
		</table>

	</ItemTemplate>
</asp:FormView>


