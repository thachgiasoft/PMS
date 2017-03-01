﻿/*
	File Generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file ViewCoVanHocTapTest.cs instead.
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
    /// Provides tests for the and <see cref="ViewCoVanHocTap"/> objects (entity, collection and repository).
    /// </summary>
    public partial class ViewCoVanHocTapTest
    {
    	// the ViewCoVanHocTap instance used to test the repository.
		private ViewCoVanHocTap mock;
		
		// the VList<ViewCoVanHocTap> instance used to test the repository.
		private VList<ViewCoVanHocTap> mockCollection;		

        /// <summary>
		/// This method is used to construct the test environment prior to running the tests.
		/// </summary>
        static private void Init_Generated()
        {
			System.Console.WriteLine(new String('-', 75));
			System.Console.WriteLine("-- Testing the ViewCoVanHocTap Entity with the {0} --", PMS.Data.DataRepository.Provider.Name);
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
		/// Selects a page of ViewCoVanHocTap objects from the database.
		/// </summary>
		private void Step_1_SelectAll_Generated()
		{
			int count = -1;
			mockCollection = DataRepository.ViewCoVanHocTapProvider.GetPaged(null, 0, 10, out count);
			Assert.IsTrue(count >= 0, "Select Query Failed with GetPaged");
			System.Console.WriteLine("DataRepository.ViewCoVanHocTapProvider.GetPaged():");			
			System.Console.WriteLine(mockCollection);			
		}
		
		/// <summary>
		/// Searches some ViewCoVanHocTap objects from the database.
		/// </summary>
		private void Step_2_Search_Generated()
		{
			int count = -1;
			mockCollection = DataRepository.ViewCoVanHocTapProvider.Find(null, null, "", 0, 10, out count);
			Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue Find Command.");
			
			System.Console.WriteLine("DataRepository.ViewCoVanHocTapProvider.Find():");			
			System.Console.WriteLine(mockCollection);
					
		}
		 //Find
			
		
		#region Serialization tests
		
		/// <summary>
		/// Serialize the mock ViewCoVanHocTap entity into a temporary file.
		/// </summary>
		private void Step_6_SerializeEntity_Generated()
		{
			string fileName = "temp_ViewCoVanHocTap.xml";
		
			XmlSerializer mySerializer = new XmlSerializer(typeof(ViewCoVanHocTap)); 
			System.IO.StreamWriter myWriter = new System.IO.StreamWriter(fileName); 
			mySerializer.Serialize(myWriter, mock); 
			myWriter.Close();
			System.Console.WriteLine("mock correctly serialized to a temporary file.");			
		}
		
		/// <summary>
		/// Deserialize the mock ViewCoVanHocTap entity from a temporary file.
		/// </summary>
		private void Step_7_DeserializeEntity_Generated()
		{
			string fileName = "temp_ViewCoVanHocTap.xml";
		
			XmlSerializer mySerializer = new XmlSerializer(typeof(ViewCoVanHocTap)); 
			System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open); 
			mock = (ViewCoVanHocTap) mySerializer.Deserialize(myFileStream);
			myFileStream.Close();
			System.IO.File.Delete(fileName);
			
			System.Console.WriteLine("mock correctly deserialized from a temporary file.");
		}
		
		/// <summary>
		/// Serialize a ViewCoVanHocTap collection into a temporary file.
		/// </summary>
		private void Step_8_SerializeCollection_Generated()
		{
			string fileName = "temp_ViewCoVanHocTapCollection.xml";
		
			VList<ViewCoVanHocTap> mockCollection = new VList<ViewCoVanHocTap>();
			mockCollection.Add(mock);
		
			XmlSerializer mySerializer = new XmlSerializer(typeof(VList<ViewCoVanHocTap>)); 
			System.IO.StreamWriter myWriter = new System.IO.StreamWriter(fileName); 
			mySerializer.Serialize(myWriter, mockCollection); 
			myWriter.Close();
			
			System.Console.WriteLine("VList<ViewCoVanHocTap> correctly serialized to a temporary file.");					
		}
		
		
		/// <summary>
		/// Deserialize a ViewCoVanHocTap collection from a temporary file.
		/// </summary>
		private void Step_9_DeserializeCollection_Generated()
		{
			string fileName = "temp_ViewCoVanHocTapCollection.xml";
		
			XmlSerializer mySerializer = new XmlSerializer(typeof(VList<ViewCoVanHocTap>)); 
			System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open); 
			VList<ViewCoVanHocTap> mockCollection = (VList<ViewCoVanHocTap>) mySerializer.Deserialize(myFileStream);
			myFileStream.Close();
			System.IO.File.Delete(fileName);
			System.Console.WriteLine("VList<ViewCoVanHocTap> correctly deserialized from a temporary file.");	
		}
		#endregion
		
		#region Mock Instance
		///<summary>
		///  Returns a Typed ViewCoVanHocTap Entity with mock values.
		///</summary>
		static public ViewCoVanHocTap CreateMockInstance()
		{		
			ViewCoVanHocTap mock = new ViewCoVanHocTap();
						
			mock.NamHoc = TestUtility.Instance.RandomString(9, false);;
			mock.HocKy = TestUtility.Instance.RandomString(9, false);;
			mock.MaLop = TestUtility.Instance.RandomString(9, false);;
			mock.SiSo = TestUtility.Instance.RandomNumber();
			mock.DepartmentId = TestUtility.Instance.RandomString(9, false);;
			mock.DepartmentName = TestUtility.Instance.RandomString(126, false);;
			mock.MaGiangVien = TestUtility.Instance.RandomNumber();
			mock.MaQuanLy = TestUtility.Instance.RandomString(9, false);;
			mock.Ho = TestUtility.Instance.RandomString(49, false);;
			mock.Ten = TestUtility.Instance.RandomString(24, false);;
			mock.HoTen = TestUtility.Instance.RandomString(75, false);;
			mock.SoTiet = TestUtility.Instance.RandomNumber();
			mock.SoTien = (decimal)TestUtility.Instance.RandomShort();
			mock.NgayTao = TestUtility.Instance.RandomDateTime();
			mock.TrangThai = TestUtility.Instance.RandomBoolean();
			mock.MaKhoaHoc = TestUtility.Instance.RandomString(9, false);;
			mock.MaCoVan = TestUtility.Instance.RandomNumber();
		   return (ViewCoVanHocTap)mock;
		}
		

		#endregion
    }
}