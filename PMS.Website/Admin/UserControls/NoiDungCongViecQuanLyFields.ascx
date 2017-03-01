<%@ Control Language="C#" ClassName="NoiDungCongViecQuanLyFields" %>

<asp:FormView ID="FormView1" runat="server">
	<ItemTemplate>
		<table border="0" cellpadding="3" cellspacing="1">
			<tr>
        <td class="literal"><asp:Label ID="lbldataNoiDung" runat="server" Text="Noi Dung:" AssociatedControlID="dataNoiDung" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNoiDung" Text='<%# Bind("NoiDung") %>'  TextMode="MultiLine"  Width="250px" Rows="5"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaCongViec" runat="server" Text="Ma Cong Viec:" AssociatedControlID="dataMaCongViec" /></td>
        <td>
					<data:EntityDropDownList runat="server" ID="dataMaCongViec" DataSourceID="MaCongViecDanhMucHoatDongQuanLyDataSource" DataTextField="MaHoatDong" DataValueField="Id" SelectedValue='<%# Bind("MaCongViec") %>' AppendNullItem="true" Required="false" NullItemText="< Please Choose ...>" />
					<data:DanhMucHoatDongQuanLyDataSource ID="MaCongViecDanhMucHoatDongQuanLyDataSource" runat="server" SelectMethod="GetAll"  />
				</td>
			</tr>
			
		</table>

	</ItemTemplate>
</asp:FormView>


