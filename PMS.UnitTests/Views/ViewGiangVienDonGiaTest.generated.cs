﻿
/*
	File Generated by NetTiers templates [www.nettiers.com]
	Important: Do not modify this file. Edit the file ViewGiangVienDonGiaTest.cs instead.
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
    /// Provides tests for the and <see cref="ViewGiangVienDonGia"/> objects (entity, collection and repository).
    /// </summary>
    public partial class ViewGiangVienDonGiaTest
    {
    	// the ViewGiangVienDonGia instance used to test the repository.
		private ViewGiangVienDonGia mock;
		
		// the VList<ViewGiangVienDonGia> instance used to test the repository.
		private VList<ViewGiangVienDonGia> mockCollection;		

        /// <summary>
		/// This method is used to construct the test environment prior to running the tests.
		/// </summary>
        static private void Init_Generated()
        {
			System.Console.WriteLine(new String('-', 75));
			System.Console.WriteLine("-- Testing the ViewGiangVienDonGia Entity with the {0} --", PMS.Data.DataRepository.Provider.Name);
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
		/// Selects a page of ViewGiangVienDonGia objects from the database.
		/// </summary>
		private void Step_1_SelectAll_Generated()
		{
			int count = -1;
			mockCollection = DataRepository.ViewGiangVienDonGiaProvider.GetPaged(null, 0, 10, out count);
			Assert.IsTrue(count >= 0, "Select Query Failed with GetPaged");
			System.Console.WriteLine("DataRepository.ViewGiangVienDonGiaProvider.GetPaged():");			
			System.Console.WriteLine(mockCollection);			
		}
		
		/// <summary>
		/// Searches some ViewGiangVienDonGia objects from the database.
		/// </summary>
		private void Step_2_Search_Generated()
		{
			int count = -1;
			mockCollection = DataRepository.ViewGiangVienDonGiaProvider.Find(null, null, "", 0, 10, out count);
			Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue Find Command.");
			
			System.Console.WriteLine("DataRepository.ViewGiangVienDonGiaProvider.Find():");			
			System.Console.WriteLine(mockCollection);
					
		}
		 //Find
			
		
		#region Serialization tests
		
		/// <summary>
		/// Serialize the mock ViewGiangVienDonGia entity into a temporary file.
		/// </summary>
		private void Step_6_SerializeEntity_Generated()
		{
			string fileName = "temp_ViewGiangVienDonGia.xml";
		
			XmlSerializer mySerializer = new XmlSerializer(typeof(ViewGiangVienDonGia)); 
			System.IO.StreamWriter myWriter = new System.IO.StreamWriter(fileName); 
			mySerializer.Serialize(myWriter, mock); 
			myWriter.Close();
			System.Console.WriteLine("mock correctly serialized to a temporary file.");			
		}
		
		/// <summary>
		/// Deserialize the mock ViewGiangVienDonGia entity from a temporary file.
		/// </summary>
		private void Step_7_DeserializeEntity_Generated()
		{
			string fileName = "temp_ViewGiangVienDonGia.xml";
		
			XmlSerializer mySerializer = new XmlSerializer(typeof(ViewGiangVienDonGia)); 
			System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open); 
			mock = (ViewGiangVienDonGia) mySerializer.Deserialize(myFileStream);
			myFileStream.Close();
			System.IO.File.Delete(fileName);
			
			System.Console.WriteLine("mock correctly deserialized from a temporary file.");
		}
		
		/// <summary>
		/// Serialize a ViewGiangVienDonGia collection into a temporary file.
		/// </summary>
		private void Step_8_SerializeCollection_Generated()
		{
			string fileName = "temp_ViewGiangVienDonGiaCollection.xml";
		
			VList<ViewGiangVienDonGia> mockCollection = new VList<ViewGiangVienDonGia>();
			mockCollection.Add(mock);
		
			XmlSerializer mySerializer = new XmlSerializer(typeof(VList<ViewGiangVienDonGia>)); 
			System.IO.StreamWriter myWriter = new System.IO.StreamWriter(fileName); 
			mySerializer.Serialize(myWriter, mockCollection); 
			myWriter.Close();
			
			System.Console.WriteLine("VList<ViewGiangVienDonGia> correctly serialized to a temporary file.");					
		}
		
		
		/// <summary>
		/// Deserialize a ViewGiangVienDonGia collection from a temporary file.
		/// </summary>
		private void Step_9_DeserializeCollection_Generated()
		{
			string fileName = "temp_ViewGiangVienDonGiaCollection.xml";
		
			XmlSerializer mySerializer = new XmlSerializer(typeof(VList<ViewGiangVienDonGia>)); 
			System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open); 
			VList<ViewGiangVienDonGia> mockCollection = (VList<ViewGiangVienDonGia>) mySerializer.Deserialize(myFileStream);
			myFileStream.Close();
			System.IO.File.Delete(fileName);
			System.Console.WriteLine("VList<ViewGiangVienDonGia> correctly deserialized from a temporary file.");	
		}
		#endregion
		
		#region Mock Instance
		///<summary>
		///  Returns a Typed ViewGiangVienDonGia Entity with mock values.
		///</summary>
		static public ViewGiangVienDonGia CreateMockInstance()
		{		
			ViewGiangVienDonGia mock = new ViewGiangVienDonGia();
						
			mock.MaGiangVien = TestUtility.Instance.RandomNumber();
			mock.MaQuanLy = TestUtility.Instance.RandomString(20, false);;
			mock.HoTen = TestUtility.Instance.RandomString(75, false);;
			mock.MaDonVi = TestUtility.Instance.RandomString(20, false);;
			mock.DonGia = (decimal)TestUtility.Instance.RandomShort();
		   return (ViewGiangVienDonGia)mock;
		}
		

		#endregion
    }
}