<%@ Control Language="C#" ClassName="NhomChucNangFields" %>

<asp:FormView ID="FormView1" runat="server">
	<ItemTemplate>
		<table border="0" cellpadding="3" cellspacing="1">
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaChucNang" runat="server" Text="Ma Chuc Nang:" AssociatedControlID="dataMaChucNang" /></td>
        <td>
					<data:EntityDropDownList runat="server" ID="dataMaChucNang" DataSourceID="MaChucNangChucNangDataSource" DataTextField="PhanLoai" DataValueField="Id" SelectedValue='<%# Bind("MaChucNang") %>' AppendNullItem="true" Required="true" NullItemText="< Please Choose ...>" ErrorText="Required" />
					<data:ChucNangDataSource ID="MaChucNangChucNangDataSource" runat="server" SelectMethod="GetAll"  />
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaNhomQuyen" runat="server" Text="Ma Nhom Quyen:" AssociatedControlID="dataMaNhomQuyen" /></td>
        <td>
					<data:EntityDropDownList runat="server" ID="dataMaNhomQuyen" DataSourceID="MaNhomQuyenNhomQuyenDataSource" DataTextField="TenNhomQuyen" DataValueField="MaNhomQuyen" SelectedValue='<%# Bind("MaNhomQuyen") %>' AppendNullItem="true" Required="true" NullItemText="< Please Choose ...>" ErrorText="Required" />
					<data:NhomQuyenDataSource ID="MaNhomQuyenNhomQuyenDataSource" runat="server" SelectMethod="GetAll"  />
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataDuLieu" runat="server" Text="Du Lieu:" AssociatedControlID="dataDuLieu" /></td>
        <td>
					<asp:HiddenField runat="server" id="dataDuLieu" Value='<%# Bind("DuLieu") %>'></asp:HiddenField>
				</td>
			</tr>
			
		</table>

	</ItemTemplate>
</asp:FormView>


