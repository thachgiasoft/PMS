﻿
/*
	File Generated by NetTiers templates [www.nettiers.com]
	Important: Do not modify this file. Edit the file ViewThongKeChucVuChiTietTest.cs instead.
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
    /// Provides tests for the and <see cref="ViewThongKeChucVuChiTiet"/> objects (entity, collection and repository).
    /// </summary>
    public partial class ViewThongKeChucVuChiTietTest
    {
    	// the ViewThongKeChucVuChiTiet instance used to test the repository.
		private ViewThongKeChucVuChiTiet mock;
		
		// the VList<ViewThongKeChucVuChiTiet> instance used to test the repository.
		private VList<ViewThongKeChucVuChiTiet> mockCollection;		

        /// <summary>
		/// This method is used to construct the test environment prior to running the tests.
		/// </summary>
        static private void Init_Generated()
        {
			System.Console.WriteLine(new String('-', 75));
			System.Console.WriteLine("-- Testing the ViewThongKeChucVuChiTiet Entity with the {0} --", PMS.Data.DataRepository.Provider.Name);
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
		/// Selects a page of ViewThongKeChucVuChiTiet objects from the database.
		/// </summary>
		private void Step_1_SelectAll_Generated()
		{
			int count = -1;
			mockCollection = DataRepository.ViewThongKeChucVuChiTietProvider.GetPaged(null, 0, 10, out count);
			Assert.IsTrue(count >= 0, "Select Query Failed with GetPaged");
			System.Console.WriteLine("DataRepository.ViewThongKeChucVuChiTietProvider.GetPaged():");			
			System.Console.WriteLine(mockCollection);			
		}
		
		/// <summary>
		/// Searches some ViewThongKeChucVuChiTiet objects from the database.
		/// </summary>
		private void Step_2_Search_Generated()
		{
			int count = -1;
			mockCollection = DataRepository.ViewThongKeChucVuChiTietProvider.Find(null, null, "", 0, 10, out count);
			Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue Find Command.");
			
			System.Console.WriteLine("DataRepository.ViewThongKeChucVuChiTietProvider.Find():");			
			System.Console.WriteLine(mockCollection);
					
		}
		 //Find
			
		
		#region Serialization tests
		
		/// <summary>
		/// Serialize the mock ViewThongKeChucVuChiTiet entity into a temporary file.
		/// </summary>
		private void Step_6_SerializeEntity_Generated()
		{
			string fileName = "temp_ViewThongKeChucVuChiTiet.xml";
		
			XmlSerializer mySerializer = new XmlSerializer(typeof(ViewThongKeChucVuChiTiet)); 
			System.IO.StreamWriter myWriter = new System.IO.StreamWriter(fileName); 
			mySerializer.Serialize(myWriter, mock); 
			myWriter.Close();
			System.Console.WriteLine("mock correctly serialized to a temporary file.");			
		}
		
		/// <summary>
		/// Deserialize the mock ViewThongKeChucVuChiTiet entity from a temporary file.
		/// </summary>
		private void Step_7_DeserializeEntity_Generated()
		{
			string fileName = "temp_ViewThongKeChucVuChiTiet.xml";
		
			XmlSerializer mySerializer = new XmlSerializer(typeof(ViewThongKeChucVuChiTiet)); 
			System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open); 
			mock = (ViewThongKeChucVuChiTiet) mySerializer.Deserialize(myFileStream);
			myFileStream.Close();
			System.IO.File.Delete(fileName);
			
			System.Console.WriteLine("mock correctly deserialized from a temporary file.");
		}
		
		/// <summary>
		/// Serialize a ViewThongKeChucVuChiTiet collection into a temporary file.
		/// </summary>
		private void Step_8_SerializeCollection_Generated()
		{
			string fileName = "temp_ViewThongKeChucVuChiTietCollection.xml";
		
			VList<ViewThongKeChucVuChiTiet> mockCollection = new VList<ViewThongKeChucVuChiTiet>();
			mockCollection.Add(mock);
		
			XmlSerializer mySerializer = new XmlSerializer(typeof(VList<ViewThongKeChucVuChiTiet>)); 
			System.IO.StreamWriter myWriter = new System.IO.StreamWriter(fileName); 
			mySerializer.Serialize(myWriter, mockCollection); 
			myWriter.Close();
			
			System.Console.WriteLine("VList<ViewThongKeChucVuChiTiet> correctly serialized to a temporary file.");					
		}
		
		
		/// <summary>
		/// Deserialize a ViewThongKeChucVuChiTiet collection from a temporary file.
		/// </summary>
		private void Step_9_DeserializeCollection_Generated()
		{
			string fileName = "temp_ViewThongKeChucVuChiTietCollection.xml";
		
			XmlSerializer mySerializer = new XmlSerializer(typeof(VList<ViewThongKeChucVuChiTiet>)); 
			System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open); 
			VList<ViewThongKeChucVuChiTiet> mockCollection = (VList<ViewThongKeChucVuChiTiet>) mySerializer.Deserialize(myFileStream);
			myFileStream.Close();
			System.IO.File.Delete(fileName);
			System.Console.WriteLine("VList<ViewThongKeChucVuChiTiet> correctly deserialized from a temporary file.");	
		}
		#endregion
		
		#region Mock Instance
		///<summary>
		///  Returns a Typed ViewThongKeChucVuChiTiet Entity with mock values.
		///</summary>
		static public ViewThongKeChucVuChiTiet CreateMockInstance()
		{		
			ViewThongKeChucVuChiTiet mock = new ViewThongKeChucVuChiTiet();
						
			mock.MaGiangVien = TestUtility.Instance.RandomNumber();
			mock.MaGiangVienQuanLy = TestUtility.Instance.RandomString(20, false);;
			mock.Ho = TestUtility.Instance.RandomString(49, false);;
			mock.Ten = TestUtility.Instance.RandomString(24, false);;
			mock.MaChucVuHienTai = TestUtility.Instance.RandomNumber();
			mock.MaChucVu = TestUtility.Instance.RandomNumber();
			mock.MaChucVuHienTaiQuanLy = TestUtility.Instance.RandomString(20, false);;
			mock.MaChucVuQuanLy = TestUtility.Instance.RandomString(20, false);;
			mock.TenChucVu = TestUtility.Instance.RandomString(99, false);;
			mock.KyHieu = TestUtility.Instance.RandomString(20, false);;
			mock.SoTiet = TestUtility.Instance.RandomNumber();
			mock.PhanTramGio = (decimal)TestUtility.Instance.RandomShort();
			mock.NguongTiet = TestUtility.Instance.RandomNumber();
			mock.NgayHieuLuc = TestUtility.Instance.RandomString(10, false);;
			mock.NgayHetHieuLuc = TestUtility.Instance.RandomString(10, false);;
			mock.TrangThai = TestUtility.Instance.RandomBoolean();
			mock.DamNhiem = TestUtility.Instance.RandomBoolean();
		   return (ViewThongKeChucVuChiTiet)mock;
		}
		

		#endregion
    }
}
