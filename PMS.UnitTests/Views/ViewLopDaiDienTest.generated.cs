﻿
/*
	File Generated by NetTiers templates [www.nettiers.com]
	Important: Do not modify this file. Edit the file ViewLopDaiDienTest.cs instead.
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
    /// Provides tests for the and <see cref="ViewLopDaiDien"/> objects (entity, collection and repository).
    /// </summary>
    public partial class ViewLopDaiDienTest
    {
    	// the ViewLopDaiDien instance used to test the repository.
		private ViewLopDaiDien mock;
		
		// the VList<ViewLopDaiDien> instance used to test the repository.
		private VList<ViewLopDaiDien> mockCollection;		

        /// <summary>
		/// This method is used to construct the test environment prior to running the tests.
		/// </summary>
        static private void Init_Generated()
        {
			System.Console.WriteLine(new String('-', 75));
			System.Console.WriteLine("-- Testing the ViewLopDaiDien Entity with the {0} --", PMS.Data.DataRepository.Provider.Name);
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
		/// Selects a page of ViewLopDaiDien objects from the database.
		/// </summary>
		private void Step_1_SelectAll_Generated()
		{
			int count = -1;
			mockCollection = DataRepository.ViewLopDaiDienProvider.GetPaged(null, 0, 10, out count);
			Assert.IsTrue(count >= 0, "Select Query Failed with GetPaged");
			System.Console.WriteLine("DataRepository.ViewLopDaiDienProvider.GetPaged():");			
			System.Console.WriteLine(mockCollection);			
		}
		
		/// <summary>
		/// Searches some ViewLopDaiDien objects from the database.
		/// </summary>
		private void Step_2_Search_Generated()
		{
			int count = -1;
			mockCollection = DataRepository.ViewLopDaiDienProvider.Find(null, null, "", 0, 10, out count);
			Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue Find Command.");
			
			System.Console.WriteLine("DataRepository.ViewLopDaiDienProvider.Find():");			
			System.Console.WriteLine(mockCollection);
					
		}
		 //Find
			
		
		#region Serialization tests
		
		/// <summary>
		/// Serialize the mock ViewLopDaiDien entity into a temporary file.
		/// </summary>
		private void Step_6_SerializeEntity_Generated()
		{
			string fileName = "temp_ViewLopDaiDien.xml";
		
			XmlSerializer mySerializer = new XmlSerializer(typeof(ViewLopDaiDien)); 
			System.IO.StreamWriter myWriter = new System.IO.StreamWriter(fileName); 
			mySerializer.Serialize(myWriter, mock); 
			myWriter.Close();
			System.Console.WriteLine("mock correctly serialized to a temporary file.");			
		}
		
		/// <summary>
		/// Deserialize the mock ViewLopDaiDien entity from a temporary file.
		/// </summary>
		private void Step_7_DeserializeEntity_Generated()
		{
			string fileName = "temp_ViewLopDaiDien.xml";
		
			XmlSerializer mySerializer = new XmlSerializer(typeof(ViewLopDaiDien)); 
			System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open); 
			mock = (ViewLopDaiDien) mySerializer.Deserialize(myFileStream);
			myFileStream.Close();
			System.IO.File.Delete(fileName);
			
			System.Console.WriteLine("mock correctly deserialized from a temporary file.");
		}
		
		/// <summary>
		/// Serialize a ViewLopDaiDien collection into a temporary file.
		/// </summary>
		private void Step_8_SerializeCollection_Generated()
		{
			string fileName = "temp_ViewLopDaiDienCollection.xml";
		
			VList<ViewLopDaiDien> mockCollection = new VList<ViewLopDaiDien>();
			mockCollection.Add(mock);
		
			XmlSerializer mySerializer = new XmlSerializer(typeof(VList<ViewLopDaiDien>)); 
			System.IO.StreamWriter myWriter = new System.IO.StreamWriter(fileName); 
			mySerializer.Serialize(myWriter, mockCollection); 
			myWriter.Close();
			
			System.Console.WriteLine("VList<ViewLopDaiDien> correctly serialized to a temporary file.");					
		}
		
		
		/// <summary>
		/// Deserialize a ViewLopDaiDien collection from a temporary file.
		/// </summary>
		private void Step_9_DeserializeCollection_Generated()
		{
			string fileName = "temp_ViewLopDaiDienCollection.xml";
		
			XmlSerializer mySerializer = new XmlSerializer(typeof(VList<ViewLopDaiDien>)); 
			System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open); 
			VList<ViewLopDaiDien> mockCollection = (VList<ViewLopDaiDien>) mySerializer.Deserialize(myFileStream);
			myFileStream.Close();
			System.IO.File.Delete(fileName);
			System.Console.WriteLine("VList<ViewLopDaiDien> correctly deserialized from a temporary file.");	
		}
		#endregion
		
		#region Mock Instance
		///<summary>
		///  Returns a Typed ViewLopDaiDien Entity with mock values.
		///</summary>
		static public ViewLopDaiDien CreateMockInstance()
		{		
			ViewLopDaiDien mock = new ViewLopDaiDien();
						
			mock.MaGiangVien = TestUtility.Instance.RandomNumber();
			mock.DonGia = (decimal)TestUtility.Instance.RandomShort();
			mock.NamHoc = TestUtility.Instance.RandomString(20, false);;
			mock.HocKy = TestUtility.Instance.RandomString(20, false);;
			mock.MaLoaiHocPhan = TestUtility.Instance.RandomByte();
			mock.LoaiHocPhan = TestUtility.Instance.RandomString(10, false);;
			mock.PhanLoai = TestUtility.Instance.RandomString(24, false);;
			mock.MaMonHoc = TestUtility.Instance.RandomString(20, false);;
			mock.TenMonHoc = TestUtility.Instance.RandomString(126, false);;
			mock.MaNhom = TestUtility.Instance.RandomString(20, false);;
		   return (ViewLopDaiDien)mock;
		}
		

		#endregion
    }
}
