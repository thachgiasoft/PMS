﻿/*
	File Generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file VThanhToanThuLaoTest.cs instead.
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
    /// Provides tests for the and <see cref="VThanhToanThuLao"/> objects (entity, collection and repository).
    /// </summary>
    public partial class VThanhToanThuLaoTest
    {
    	// the VThanhToanThuLao instance used to test the repository.
		private VThanhToanThuLao mock;
		
		// the VList<VThanhToanThuLao> instance used to test the repository.
		private VList<VThanhToanThuLao> mockCollection;		

        /// <summary>
		/// This method is used to construct the test environment prior to running the tests.
		/// </summary>
        static private void Init_Generated()
        {
			System.Console.WriteLine(new String('-', 75));
			System.Console.WriteLine("-- Testing the VThanhToanThuLao Entity with the {0} --", PMS.Data.DataRepository.Provider.Name);
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
		/// Selects a page of VThanhToanThuLao objects from the database.
		/// </summary>
		private void Step_1_SelectAll_Generated()
		{
			int count = -1;
			mockCollection = DataRepository.VThanhToanThuLaoProvider.GetPaged(null, 0, 10, out count);
			Assert.IsTrue(count >= 0, "Select Query Failed with GetPaged");
			System.Console.WriteLine("DataRepository.VThanhToanThuLaoProvider.GetPaged():");			
			System.Console.WriteLine(mockCollection);			
		}
		
		/// <summary>
		/// Searches some VThanhToanThuLao objects from the database.
		/// </summary>
		private void Step_2_Search_Generated()
		{
			int count = -1;
			mockCollection = DataRepository.VThanhToanThuLaoProvider.Find(null, null, "", 0, 10, out count);
			Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue Find Command.");
			
			System.Console.WriteLine("DataRepository.VThanhToanThuLaoProvider.Find():");			
			System.Console.WriteLine(mockCollection);
					
		}
		 //Find
			
		
		#region Serialization tests
		
		/// <summary>
		/// Serialize the mock VThanhToanThuLao entity into a temporary file.
		/// </summary>
		private void Step_6_SerializeEntity_Generated()
		{
			string fileName = "temp_VThanhToanThuLao.xml";
		
			XmlSerializer mySerializer = new XmlSerializer(typeof(VThanhToanThuLao)); 
			System.IO.StreamWriter myWriter = new System.IO.StreamWriter(fileName); 
			mySerializer.Serialize(myWriter, mock); 
			myWriter.Close();
			System.Console.WriteLine("mock correctly serialized to a temporary file.");			
		}
		
		/// <summary>
		/// Deserialize the mock VThanhToanThuLao entity from a temporary file.
		/// </summary>
		private void Step_7_DeserializeEntity_Generated()
		{
			string fileName = "temp_VThanhToanThuLao.xml";
		
			XmlSerializer mySerializer = new XmlSerializer(typeof(VThanhToanThuLao)); 
			System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open); 
			mock = (VThanhToanThuLao) mySerializer.Deserialize(myFileStream);
			myFileStream.Close();
			System.IO.File.Delete(fileName);
			
			System.Console.WriteLine("mock correctly deserialized from a temporary file.");
		}
		
		/// <summary>
		/// Serialize a VThanhToanThuLao collection into a temporary file.
		/// </summary>
		private void Step_8_SerializeCollection_Generated()
		{
			string fileName = "temp_VThanhToanThuLaoCollection.xml";
		
			VList<VThanhToanThuLao> mockCollection = new VList<VThanhToanThuLao>();
			mockCollection.Add(mock);
		
			XmlSerializer mySerializer = new XmlSerializer(typeof(VList<VThanhToanThuLao>)); 
			System.IO.StreamWriter myWriter = new System.IO.StreamWriter(fileName); 
			mySerializer.Serialize(myWriter, mockCollection); 
			myWriter.Close();
			
			System.Console.WriteLine("VList<VThanhToanThuLao> correctly serialized to a temporary file.");					
		}
		
		
		/// <summary>
		/// Deserialize a VThanhToanThuLao collection from a temporary file.
		/// </summary>
		private void Step_9_DeserializeCollection_Generated()
		{
			string fileName = "temp_VThanhToanThuLaoCollection.xml";
		
			XmlSerializer mySerializer = new XmlSerializer(typeof(VList<VThanhToanThuLao>)); 
			System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open); 
			VList<VThanhToanThuLao> mockCollection = (VList<VThanhToanThuLao>) mySerializer.Deserialize(myFileStream);
			myFileStream.Close();
			System.IO.File.Delete(fileName);
			System.Console.WriteLine("VList<VThanhToanThuLao> correctly deserialized from a temporary file.");	
		}
		#endregion
		
		#region Mock Instance
		///<summary>
		///  Returns a Typed VThanhToanThuLao Entity with mock values.
		///</summary>
		static public VThanhToanThuLao CreateMockInstance()
		{		
			VThanhToanThuLao mock = new VThanhToanThuLao();
						
			mock.MaLoaiGiangVien = TestUtility.Instance.RandomNumber();
			mock.MaGiangVien = TestUtility.Instance.RandomNumber();
			mock.MaQuanLy = TestUtility.Instance.RandomString(9, false);;
			mock.HoTen = TestUtility.Instance.RandomString(75, false);;
			mock.HoDem = TestUtility.Instance.RandomString(49, false);;
			mock.Ten = TestUtility.Instance.RandomString(24, false);;
			mock.ChucDanh = TestUtility.Instance.RandomString(9, false);;
			mock.MaDonVi = TestUtility.Instance.RandomString(9, false);;
			mock.MaNhomKhoiLuong = TestUtility.Instance.RandomString(24, false);;
			mock.TietGioiHan = (decimal)TestUtility.Instance.RandomShort();
			mock.TietNghiaVu = TestUtility.Instance.RandomNumber();
			mock.TietQuyDoi = (decimal)TestUtility.Instance.RandomShort();
			mock.TietDoAn = (decimal)TestUtility.Instance.RandomShort();
			mock.TrongGio = (decimal)TestUtility.Instance.RandomShort();
			mock.NgoaiGio = (decimal)TestUtility.Instance.RandomShort();
			mock.DonGia = (decimal)TestUtility.Instance.RandomShort();
			mock.HocKy = TestUtility.Instance.RandomString(9, false);;
			mock.NamHoc = TestUtility.Instance.RandomString(9, false);;
		   return (VThanhToanThuLao)mock;
		}
		

		#endregion
    }
}
