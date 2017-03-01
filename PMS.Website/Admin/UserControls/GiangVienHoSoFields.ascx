<%@ Control Language="C#" ClassName="GiangVienHoSoFields" %>

<asp:FormView ID="FormView1" runat="server">
	<ItemTemplate>
		<table border="0" cellpadding="3" cellspacing="1">
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaHoSo" runat="server" Text="Ma Ho So:" AssociatedControlID="dataMaHoSo" /></td>
        <td>
					<data:EntityDropDownList runat="server" ID="dataMaHoSo" DataSourceID="MaHoSoHoSoDataSource" DataTextField="MaQuanLy" DataValueField="MaHoSo" SelectedValue='<%# Bind("MaHoSo") %>' AppendNullItem="true" Required="true" NullItemText="< Please Choose ...>" ErrorText="Required" />
					<data:HoSoDataSource ID="MaHoSoHoSoDataSource" runat="server" SelectMethod="GetAll"  />
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaGiangVien" runat="server" Text="Ma Giang Vien:" AssociatedControlID="dataMaGiangVien" /></td>
        <td>
					<data:EntityDropDownList runat="server" ID="dataMaGiangVien" DataSourceID="MaGiangVienGiangVienDataSource" DataTextField="MaDanToc" DataValueField="MaGiangVien" SelectedValue='<%# Bind("MaGiangVien") %>' AppendNullItem="true" Required="true" NullItemText="< Please Choose ...>" ErrorText="Required" />
					<data:GiangVienDataSource ID="MaGiangVienGiangVienDataSource" runat="server" SelectMethod="GetAll"  />
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataSoHoSo" runat="server" Text="So Ho So:" AssociatedControlID="dataSoHoSo" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataSoHoSo" Text='<%# Bind("SoHoSo") %>' MaxLength="50"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNgayCap" runat="server" Text="Ngay Cap:" AssociatedControlID="dataNgayCap" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNgayCap" Text='<%# Bind("NgayCap") %>' MaxLength="10"></asp:TextBox>
				</td>
			</tr>
			
		</table>

	</ItemTemplate>
</asp:FormView>


