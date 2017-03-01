﻿/*
	File Generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file ViewDanhSachLopPhanCongGiangDayTest.cs instead.
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
    /// Provides tests for the and <see cref="ViewDanhSachLopPhanCongGiangDay"/> objects (entity, collection and repository).
    /// </summary>
    public partial class ViewDanhSachLopPhanCongGiangDayTest
    {
    	// the ViewDanhSachLopPhanCongGiangDay instance used to test the repository.
		private ViewDanhSachLopPhanCongGiangDay mock;
		
		// the VList<ViewDanhSachLopPhanCongGiangDay> instance used to test the repository.
		private VList<ViewDanhSachLopPhanCongGiangDay> mockCollection;		

        /// <summary>
		/// This method is used to construct the test environment prior to running the tests.
		/// </summary>
        static private void Init_Generated()
        {
			System.Console.WriteLine(new String('-', 75));
			System.Console.WriteLine("-- Testing the ViewDanhSachLopPhanCongGiangDay Entity with the {0} --", PMS.Data.DataRepository.Provider.Name);
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
		/// Selects a page of ViewDanhSachLopPhanCongGiangDay objects from the database.
		/// </summary>
		private void Step_1_SelectAll_Generated()
		{
			int count = -1;
			mockCollection = DataRepository.ViewDanhSachLopPhanCongGiangDayProvider.GetPaged(null, 0, 10, out count);
			Assert.IsTrue(count >= 0, "Select Query Failed with GetPaged");
			System.Console.WriteLine("DataRepository.ViewDanhSachLopPhanCongGiangDayProvider.GetPaged():");			
			System.Console.WriteLine(mockCollection);			
		}
		
		/// <summary>
		/// Searches some ViewDanhSachLopPhanCongGiangDay objects from the database.
		/// </summary>
		private void Step_2_Search_Generated()
		{
			int count = -1;
			mockCollection = DataRepository.ViewDanhSachLopPhanCongGiangDayProvider.Find(null, null, "", 0, 10, out count);
			Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue Find Command.");
			
			System.Console.WriteLine("DataRepository.ViewDanhSachLopPhanCongGiangDayProvider.Find():");			
			System.Console.WriteLine(mockCollection);
					
		}
		 //Find
			
		
		#region Serialization tests
		
		/// <summary>
		/// Serialize the mock ViewDanhSachLopPhanCongGiangDay entity into a temporary file.
		/// </summary>
		private void Step_6_SerializeEntity_Generated()
		{
			string fileName = "temp_ViewDanhSachLopPhanCongGiangDay.xml";
		
			XmlSerializer mySerializer = new XmlSerializer(typeof(ViewDanhSachLopPhanCongGiangDay)); 
			System.IO.StreamWriter myWriter = new System.IO.StreamWriter(fileName); 
			mySerializer.Serialize(myWriter, mock); 
			myWriter.Close();
			System.Console.WriteLine("mock correctly serialized to a temporary file.");			
		}
		
		/// <summary>
		/// Deserialize the mock ViewDanhSachLopPhanCongGiangDay entity from a temporary file.
		/// </summary>
		private void Step_7_DeserializeEntity_Generated()
		{
			string fileName = "temp_ViewDanhSachLopPhanCongGiangDay.xml";
		
			XmlSerializer mySerializer = new XmlSerializer(typeof(ViewDanhSachLopPhanCongGiangDay)); 
			System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open); 
			mock = (ViewDanhSachLopPhanCongGiangDay) mySerializer.Deserialize(myFileStream);
			myFileStream.Close();
			System.IO.File.Delete(fileName);
			
			System.Console.WriteLine("mock correctly deserialized from a temporary file.");
		}
		
		/// <summary>
		/// Serialize a ViewDanhSachLopPhanCongGiangDay collection into a temporary file.
		/// </summary>
		private void Step_8_SerializeCollection_Generated()
		{
			string fileName = "temp_ViewDanhSachLopPhanCongGiangDayCollection.xml";
		
			VList<ViewDanhSachLopPhanCongGiangDay> mockCollection = new VList<ViewDanhSachLopPhanCongGiangDay>();
			mockCollection.Add(mock);
		
			XmlSerializer mySerializer = new XmlSerializer(typeof(VList<ViewDanhSachLopPhanCongGiangDay>)); 
			System.IO.StreamWriter myWriter = new System.IO.StreamWriter(fileName); 
			mySerializer.Serialize(myWriter, mockCollection); 
			myWriter.Close();
			
			System.Console.WriteLine("VList<ViewDanhSachLopPhanCongGiangDay> correctly serialized to a temporary file.");					
		}
		
		
		/// <summary>
		/// Deserialize a ViewDanhSachLopPhanCongGiangDay collection from a temporary file.
		/// </summary>
		private void Step_9_DeserializeCollection_Generated()
		{
			string fileName = "temp_ViewDanhSachLopPhanCongGiangDayCollection.xml";
		
			XmlSerializer mySerializer = new XmlSerializer(typeof(VList<ViewDanhSachLopPhanCongGiangDay>)); 
			System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open); 
			VList<ViewDanhSachLopPhanCongGiangDay> mockCollection = (VList<ViewDanhSachLopPhanCongGiangDay>) mySerializer.Deserialize(myFileStream);
			myFileStream.Close();
			System.IO.File.Delete(fileName);
			System.Console.WriteLine("VList<ViewDanhSachLopPhanCongGiangDay> correctly deserialized from a temporary file.");	
		}
		#endregion
		
		#region Mock Instance
		///<summary>
		///  Returns a Typed ViewDanhSachLopPhanCongGiangDay Entity with mock values.
		///</summary>
		static public ViewDanhSachLopPhanCongGiangDay CreateMockInstance()
		{		
			ViewDanhSachLopPhanCongGiangDay mock = new ViewDanhSachLopPhanCongGiangDay();
						
			mock.MaGocLhp = TestUtility.Instance.RandomString(14, false);;
			mock.MaLhp = TestUtility.Instance.RandomString(14, false);;
			mock.TenHp = TestUtility.Instance.RandomString(126, false);;
			mock.LoaiHp = TestUtility.Instance.RandomString(49, false);;
			mock.SoTc = TestUtility.Instance.RandomString(37, false);;
			mock.SiSoLop = (decimal)TestUtility.Instance.RandomShort();
			mock.SiSoDk = TestUtility.Instance.RandomNumber();
			mock.MaLop = TestUtility.Instance.RandomString(126, false);;
			mock.MaCbgd = TestUtility.Instance.RandomString(126, false);;
			mock.TenCbgd = TestUtility.Instance.RandomString(126, false);;
			mock.Tkb = TestUtility.Instance.RandomString(126, false);;
			mock.HocKy = TestUtility.Instance.RandomString(9, false);;
			mock.NamHoc = TestUtility.Instance.RandomString(9, false);;
			mock.MaGiangVien = TestUtility.Instance.RandomString(9, false);;
		   return (ViewDanhSachLopPhanCongGiangDay)mock;
		}
		

		#endregion
    }
}
