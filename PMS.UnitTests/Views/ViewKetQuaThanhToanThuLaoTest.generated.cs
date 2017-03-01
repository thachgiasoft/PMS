﻿/*
	File Generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file ViewKetQuaThanhToanThuLaoTest.cs instead.
*/
#region Using directives

using System;
using System.Xml;
using System.Xml.Serialization;
using NUnit.Framework;
using PMS.Entities;
using PMS.Data;

#endregion

namespace PMS.UnitTests
{
    /// <summary>
    /// Provides tests for the and <see cref="ViewKetQuaThanhToanThuLao"/> objects (entity, collection and repository).
    /// </summary>
    public partial class ViewKetQuaThanhToanThuLaoTest
    {
    	// the ViewKetQuaThanhToanThuLao instance used to test the repository.
		private ViewKetQuaThanhToanThuLao mock;
		
		// the VList<ViewKetQuaThanhToanThuLao> instance used to test the repository.
		private VList<ViewKetQuaThanhToanThuLao> mockCollection;		

        /// <summary>
		/// This method is used to construct the test environment prior to running the tests.
		/// </summary>
        static private void Init_Generated()
        {
			System.Console.WriteLine(new String('-', 75));
			System.Console.WriteLine("-- Testing the ViewKetQuaThanhToanThuLao Entity with the {0} --", PMS.Data.DataRepository.Provider.Name);
			System.Console.WriteLine(new String('-', 75));
        }
    
    	/// <summary>
		/// This method is used to restore the environment after the tests are completed.
		/// </summary>
        static private void CleanUp_Generated()
        {       	
			System.Console.WriteLine();
			System.Console.WriteLine();
        }
		
		/// <summary>
		/// Selects a page of ViewKetQuaThanhToanThuLao objects from the database.
		/// </summary>
		private void Step_1_SelectAll_Generated()
		{
			int count = -1;
			mockCollection = DataRepository.ViewKetQuaThanhToanThuLaoProvider.GetPaged(null, 0, 10, out count);
			Assert.IsTrue(count >= 0, "Select Query Failed with GetPaged");
			System.Console.WriteLine("DataRepository.ViewKetQuaThanhToanThuLaoProvider.GetPaged():");			
			System.Console.WriteLine(mockCollection);			
		}
		
		/// <summary>
		/// Searches some ViewKetQuaThanhToanThuLao objects from the database.
		/// </summary>
		private void Step_2_Search_Generated()
		{
			int count = -1;
			mockCollection = DataRepository.ViewKetQuaThanhToanThuLaoProvider.Find(null, null, "", 0, 10, out count);
			Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue Find Command.");
			
			System.Console.WriteLine("DataRepository.ViewKetQuaThanhToanThuLaoProvider.Find():");			
			System.Console.WriteLine(mockCollection);
					
		}
		 //Find
			
		
		#region Serialization tests
		
		/// <summary>
		/// Serialize the mock ViewKetQuaThanhToanThuLao entity into a temporary file.
		/// </summary>
		private void Step_6_SerializeEntity_Generated()
		{
			string fileName = "temp_ViewKetQuaThanhToanThuLao.xml";
		
			XmlSerializer mySerializer = new XmlSerializer(typeof(ViewKetQuaThanhToanThuLao)); 
			System.IO.StreamWriter myWriter = new System.IO.StreamWriter(fileName); 
			mySerializer.Serialize(myWriter, mock); 
			myWriter.Close();
			System.Console.WriteLine("mock correctly serialized to a temporary file.");			
		}
		
		/// <summary>
		/// Deserialize the mock ViewKetQuaThanhToanThuLao entity from a temporary file.
		/// </summary>
		private void Step_7_DeserializeEntity_Generated()
		{
			string fileName = "temp_ViewKetQuaThanhToanThuLao.xml";
		
			XmlSerializer mySerializer = new XmlSerializer(typeof(ViewKetQuaThanhToanThuLao)); 
			System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open); 
			mock = (ViewKetQuaThanhToanThuLao) mySerializer.Deserialize(myFileStream);
			myFileStream.Close();
			System.IO.File.Delete(fileName);
			
			System.Console.WriteLine("mock correctly deserialized from a temporary file.");
		}
		
		/// <summary>
		/// Serialize a ViewKetQuaThanhToanThuLao collection into a temporary file.
		/// </summary>
		private void Step_8_SerializeCollection_Generated()
		{
			string fileName = "temp_ViewKetQuaThanhToanThuLaoCollection.xml";
		
			VList<ViewKetQuaThanhToanThuLao> mockCollection = new VList<ViewKetQuaThanhToanThuLao>();
			mockCollection.Add(mock);
		
			XmlSerializer mySerializer = new XmlSerializer(typeof(VList<ViewKetQuaThanhToanThuLao>)); 
			System.IO.StreamWriter myWriter = new System.IO.StreamWriter(fileName); 
			mySerializer.Serialize(myWriter, mockCollection); 
			myWriter.Close();
			
			System.Console.WriteLine("VList<ViewKetQuaThanhToanThuLao> correctly serialized to a temporary file.");					
		}
		
		
		/// <summary>
		/// Deserialize a ViewKetQuaThanhToanThuLao collection from a temporary file.
		/// </summary>
		private void Step_9_DeserializeCollection_Generated()
		{
			string fileName = "temp_ViewKetQuaThanhToanThuLaoCollection.xml";
		
			XmlSerializer mySerializer = new XmlSerializer(typeof(VList<ViewKetQuaThanhToanThuLao>)); 
			System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open); 
			VList<ViewKetQuaThanhToanThuLao> mockCollection = (VList<ViewKetQuaThanhToanThuLao>) mySerializer.Deserialize(myFileStream);
			myFileStream.Close();
			System.IO.File.Delete(fileName);
			System.Console.WriteLine("VList<ViewKetQuaThanhToanThuLao> correctly deserialized from a temporary file.");	
		}
		#endregion
		
		#region Mock Instance
		///<summary>
		///  Returns a Typed ViewKetQuaThanhToanThuLao Entity with mock values.
		///</summary>
		static public ViewKetQuaThanhToanThuLao CreateMockInstance()
		{		
			ViewKetQuaThanhToanThuLao mock = new ViewKetQuaThanhToanThuLao();
						
			mock.MaGiangVien = TestUtility.Instance.RandomNumber();
			mock.MaQuanLy = TestUtility.Instance.RandomString(9, false);;
			mock.Ho = TestUtility.Instance.RandomString(49, false);;
			mock.Ten = TestUtility.Instance.RandomString(24, false);;
			mock.HoTen = TestUtility.Instance.RandomString(75, false);;
			mock.NamHoc = TestUtility.Instance.RandomString(9, false);;
			mock.HocKy = TestUtility.Instance.RandomString(9, false);;
			mock.MaHocHam = TestUtility.Instance.RandomNumber();
			mock.TenHocHam = TestUtility.Instance.RandomString(99, false);;
			mock.MaHocVi = TestUtility.Instance.RandomNumber();
			mock.TenHocVi = TestUtility.Instance.RandomString(99, false);;
			mock.MaLoaiGiangVien = TestUtility.Instance.RandomNumber();
			mock.TenLoaiGiangVien = TestUtility.Instance.RandomString(49, false);;
			mock.MaDonVi = TestUtility.Instance.RandomString(9, false);;
			mock.TenDonVi = TestUtility.Instance.RandomString(126, false);;
			mock.Loai = TestUtility.Instance.RandomString(24, false);;
			mock.PhanLoai = TestUtility.Instance.RandomString(49, false);;
			mock.MaMonHoc = TestUtility.Instance.RandomString(9, false);;
			mock.TenMonHoc = TestUtility.Instance.RandomString(499, false);;
			mock.LoaiHocPhan = TestUtility.Instance.RandomString(99, false);;
			mock.Nhom = TestUtility.Instance.RandomString(24, false);;
			mock.MaLop = TestUtility.Instance.RandomString(99, false);;
			mock.LopClc = TestUtility.Instance.RandomBoolean();
			mock.SiSo = TestUtility.Instance.RandomNumber();
			mock.TietThucDay = (decimal)TestUtility.Instance.RandomShort();
			mock.TietChuNhat = (decimal)TestUtility.Instance.RandomShort();
			mock.HeSoHocKy = (decimal)TestUtility.Instance.RandomShort();
			mock.HeSoLopDong = (decimal)TestUtility.Instance.RandomShort();
			mock.TietQuyDoi = (decimal)TestUtility.Instance.RandomShort();
			mock.DonGia = (decimal)TestUtility.Instance.RandomShort();
			mock.ThanhTien = (decimal)TestUtility.Instance.RandomShort();
			mock.LanChot = TestUtility.Instance.RandomNumber();
			mock.NgayCapNhat = TestUtility.Instance.RandomDateTime();
		   return (ViewKetQuaThanhToanThuLao)mock;
		}
		

		#endregion
    }
}
