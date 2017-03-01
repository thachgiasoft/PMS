﻿
/*
	File Generated by NetTiers templates [www.nettiers.com]
	Important: Do not modify this file. Edit the file VwThongKeHoSoDaNopChuaNopTest.cs instead.
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
    /// Provides tests for the and <see cref="VwThongKeHoSoDaNopChuaNop"/> objects (entity, collection and repository).
    /// </summary>
    public partial class VwThongKeHoSoDaNopChuaNopTest
    {
    	// the VwThongKeHoSoDaNopChuaNop instance used to test the repository.
		private VwThongKeHoSoDaNopChuaNop mock;
		
		// the VList<VwThongKeHoSoDaNopChuaNop> instance used to test the repository.
		private VList<VwThongKeHoSoDaNopChuaNop> mockCollection;		

        /// <summary>
		/// This method is used to construct the test environment prior to running the tests.
		/// </summary>
        static private void Init_Generated()
        {
			System.Console.WriteLine(new String('-', 75));
			System.Console.WriteLine("-- Testing the VwThongKeHoSoDaNopChuaNop Entity with the {0} --", PMS.Data.DataRepository.Provider.Name);
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
		/// Selects a page of VwThongKeHoSoDaNopChuaNop objects from the database.
		/// </summary>
		private void Step_1_SelectAll_Generated()
		{
			int count = -1;
			mockCollection = DataRepository.VwThongKeHoSoDaNopChuaNopProvider.GetPaged(null, 0, 10, out count);
			Assert.IsTrue(count >= 0, "Select Query Failed with GetPaged");
			System.Console.WriteLine("DataRepository.VwThongKeHoSoDaNopChuaNopProvider.GetPaged():");			
			System.Console.WriteLine(mockCollection);			
		}
		
		/// <summary>
		/// Searches some VwThongKeHoSoDaNopChuaNop objects from the database.
		/// </summary>
		private void Step_2_Search_Generated()
		{
			int count = -1;
			mockCollection = DataRepository.VwThongKeHoSoDaNopChuaNopProvider.Find(null, null, "", 0, 10, out count);
			Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue Find Command.");
			
			System.Console.WriteLine("DataRepository.VwThongKeHoSoDaNopChuaNopProvider.Find():");			
			System.Console.WriteLine(mockCollection);
					
		}
		 //Find
			
		
		#region Serialization tests
		
		/// <summary>
		/// Serialize the mock VwThongKeHoSoDaNopChuaNop entity into a temporary file.
		/// </summary>
		private void Step_6_SerializeEntity_Generated()
		{
			string fileName = "temp_VwThongKeHoSoDaNopChuaNop.xml";
		
			XmlSerializer mySerializer = new XmlSerializer(typeof(VwThongKeHoSoDaNopChuaNop)); 
			System.IO.StreamWriter myWriter = new System.IO.StreamWriter(fileName); 
			mySerializer.Serialize(myWriter, mock); 
			myWriter.Close();
			System.Console.WriteLine("mock correctly serialized to a temporary file.");			
		}
		
		/// <summary>
		/// Deserialize the mock VwThongKeHoSoDaNopChuaNop entity from a temporary file.
		/// </summary>
		private void Step_7_DeserializeEntity_Generated()
		{
			string fileName = "temp_VwThongKeHoSoDaNopChuaNop.xml";
		
			XmlSerializer mySerializer = new XmlSerializer(typeof(VwThongKeHoSoDaNopChuaNop)); 
			System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open); 
			mock = (VwThongKeHoSoDaNopChuaNop) mySerializer.Deserialize(myFileStream);
			myFileStream.Close();
			System.IO.File.Delete(fileName);
			
			System.Console.WriteLine("mock correctly deserialized from a temporary file.");
		}
		
		/// <summary>
		/// Serialize a VwThongKeHoSoDaNopChuaNop collection into a temporary file.
		/// </summary>
		private void Step_8_SerializeCollection_Generated()
		{
			string fileName = "temp_VwThongKeHoSoDaNopChuaNopCollection.xml";
		
			VList<VwThongKeHoSoDaNopChuaNop> mockCollection = new VList<VwThongKeHoSoDaNopChuaNop>();
			mockCollection.Add(mock);
		
			XmlSerializer mySerializer = new XmlSerializer(typeof(VList<VwThongKeHoSoDaNopChuaNop>)); 
			System.IO.StreamWriter myWriter = new System.IO.StreamWriter(fileName); 
			mySerializer.Serialize(myWriter, mockCollection); 
			myWriter.Close();
			
			System.Console.WriteLine("VList<VwThongKeHoSoDaNopChuaNop> correctly serialized to a temporary file.");					
		}
		
		
		/// <summary>
		/// Deserialize a VwThongKeHoSoDaNopChuaNop collection from a temporary file.
		/// </summary>
		private void Step_9_DeserializeCollection_Generated()
		{
			string fileName = "temp_VwThongKeHoSoDaNopChuaNopCollection.xml";
		
			XmlSerializer mySerializer = new XmlSerializer(typeof(VList<VwThongKeHoSoDaNopChuaNop>)); 
			System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open); 
			VList<VwThongKeHoSoDaNopChuaNop> mockCollection = (VList<VwThongKeHoSoDaNopChuaNop>) mySerializer.Deserialize(myFileStream);
			myFileStream.Close();
			System.IO.File.Delete(fileName);
			System.Console.WriteLine("VList<VwThongKeHoSoDaNopChuaNop> correctly deserialized from a temporary file.");	
		}
		#endregion
		
		#region Mock Instance
		///<summary>
		///  Returns a Typed VwThongKeHoSoDaNopChuaNop Entity with mock values.
		///</summary>
		static public VwThongKeHoSoDaNopChuaNop CreateMockInstance()
		{		
			VwThongKeHoSoDaNopChuaNop mock = new VwThongKeHoSoDaNopChuaNop();
						
			mock.MaGiangVien = TestUtility.Instance.RandomNumber();
			mock.MaGiangVienQuanLy = TestUtility.Instance.RandomString(20, false);;
			mock.MaHoSoDaNop = TestUtility.Instance.RandomString(20, false);;
			mock.TenHoSo = TestUtility.Instance.RandomString(49, false);;
			mock.MaHoSoChuaNop = TestUtility.Instance.RandomString(20, false);;
			mock.SoHoSo = TestUtility.Instance.RandomString(24, false);;
			mock.NgayCap = TestUtility.Instance.RandomString(10, false);;
		   return (VwThongKeHoSoDaNopChuaNop)mock;
		}
		

		#endregion
    }
}
