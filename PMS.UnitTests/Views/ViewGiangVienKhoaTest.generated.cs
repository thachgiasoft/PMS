﻿/*
	File Generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file ViewGiangVienKhoaTest.cs instead.
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
    /// Provides tests for the and <see cref="ViewGiangVienKhoa"/> objects (entity, collection and repository).
    /// </summary>
    public partial class ViewGiangVienKhoaTest
    {
    	// the ViewGiangVienKhoa instance used to test the repository.
		private ViewGiangVienKhoa mock;
		
		// the VList<ViewGiangVienKhoa> instance used to test the repository.
		private VList<ViewGiangVienKhoa> mockCollection;		

        /// <summary>
		/// This method is used to construct the test environment prior to running the tests.
		/// </summary>
        static private void Init_Generated()
        {
			System.Console.WriteLine(new String('-', 75));
			System.Console.WriteLine("-- Testing the ViewGiangVienKhoa Entity with the {0} --", PMS.Data.DataRepository.Provider.Name);
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
		/// Selects a page of ViewGiangVienKhoa objects from the database.
		/// </summary>
		private void Step_1_SelectAll_Generated()
		{
			int count = -1;
			mockCollection = DataRepository.ViewGiangVienKhoaProvider.GetPaged(null, 0, 10, out count);
			Assert.IsTrue(count >= 0, "Select Query Failed with GetPaged");
			System.Console.WriteLine("DataRepository.ViewGiangVienKhoaProvider.GetPaged():");			
			System.Console.WriteLine(mockCollection);			
		}
		
		/// <summary>
		/// Searches some ViewGiangVienKhoa objects from the database.
		/// </summary>
		private void Step_2_Search_Generated()
		{
			int count = -1;
			mockCollection = DataRepository.ViewGiangVienKhoaProvider.Find(null, null, "", 0, 10, out count);
			Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue Find Command.");
			
			System.Console.WriteLine("DataRepository.ViewGiangVienKhoaProvider.Find():");			
			System.Console.WriteLine(mockCollection);
					
		}
		 //Find
			
		
		#region Serialization tests
		
		/// <summary>
		/// Serialize the mock ViewGiangVienKhoa entity into a temporary file.
		/// </summary>
		private void Step_6_SerializeEntity_Generated()
		{
			string fileName = "temp_ViewGiangVienKhoa.xml";
		
			XmlSerializer mySerializer = new XmlSerializer(typeof(ViewGiangVienKhoa)); 
			System.IO.StreamWriter myWriter = new System.IO.StreamWriter(fileName); 
			mySerializer.Serialize(myWriter, mock); 
			myWriter.Close();
			System.Console.WriteLine("mock correctly serialized to a temporary file.");			
		}
		
		/// <summary>
		/// Deserialize the mock ViewGiangVienKhoa entity from a temporary file.
		/// </summary>
		private void Step_7_DeserializeEntity_Generated()
		{
			string fileName = "temp_ViewGiangVienKhoa.xml";
		
			XmlSerializer mySerializer = new XmlSerializer(typeof(ViewGiangVienKhoa)); 
			System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open); 
			mock = (ViewGiangVienKhoa) mySerializer.Deserialize(myFileStream);
			myFileStream.Close();
			System.IO.File.Delete(fileName);
			
			System.Console.WriteLine("mock correctly deserialized from a temporary file.");
		}
		
		/// <summary>
		/// Serialize a ViewGiangVienKhoa collection into a temporary file.
		/// </summary>
		private void Step_8_SerializeCollection_Generated()
		{
			string fileName = "temp_ViewGiangVienKhoaCollection.xml";
		
			VList<ViewGiangVienKhoa> mockCollection = new VList<ViewGiangVienKhoa>();
			mockCollection.Add(mock);
		
			XmlSerializer mySerializer = new XmlSerializer(typeof(VList<ViewGiangVienKhoa>)); 
			System.IO.StreamWriter myWriter = new System.IO.StreamWriter(fileName); 
			mySerializer.Serialize(myWriter, mockCollection); 
			myWriter.Close();
			
			System.Console.WriteLine("VList<ViewGiangVienKhoa> correctly serialized to a temporary file.");					
		}
		
		
		/// <summary>
		/// Deserialize a ViewGiangVienKhoa collection from a temporary file.
		/// </summary>
		private void Step_9_DeserializeCollection_Generated()
		{
			string fileName = "temp_ViewGiangVienKhoaCollection.xml";
		
			XmlSerializer mySerializer = new XmlSerializer(typeof(VList<ViewGiangVienKhoa>)); 
			System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open); 
			VList<ViewGiangVienKhoa> mockCollection = (VList<ViewGiangVienKhoa>) mySerializer.Deserialize(myFileStream);
			myFileStream.Close();
			System.IO.File.Delete(fileName);
			System.Console.WriteLine("VList<ViewGiangVienKhoa> correctly deserialized from a temporary file.");	
		}
		#endregion
		
		#region Mock Instance
		///<summary>
		///  Returns a Typed ViewGiangVienKhoa Entity with mock values.
		///</summary>
		static public ViewGiangVienKhoa CreateMockInstance()
		{		
			ViewGiangVienKhoa mock = new ViewGiangVienKhoa();
						
			mock.MaGiangVien = TestUtility.Instance.RandomNumber();
			mock.MaKhoa = TestUtility.Instance.RandomString(9, false);;
			mock.TenKhoa = TestUtility.Instance.RandomString(126, false);;
			mock.MaQuanLy = TestUtility.Instance.RandomString(9, false);;
			mock.HoTen = TestUtility.Instance.RandomString(75, false);;
			mock.MaBoMon = TestUtility.Instance.RandomString(9, false);;
			mock.TenBoMon = TestUtility.Instance.RandomString(126, false);;
			mock.MaDonVi = TestUtility.Instance.RandomString(9, false);;
		   return (ViewGiangVienKhoa)mock;
		}
		

		#endregion
    }
}