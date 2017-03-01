﻿
/*
	File Generated by NetTiers templates [www.nettiers.com]
	Important: Do not modify this file. Edit the file ViewPhanNhomLopHocPhanTest.cs instead.
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
    /// Provides tests for the and <see cref="ViewPhanNhomLopHocPhan"/> objects (entity, collection and repository).
    /// </summary>
    public partial class ViewPhanNhomLopHocPhanTest
    {
    	// the ViewPhanNhomLopHocPhan instance used to test the repository.
		private ViewPhanNhomLopHocPhan mock;
		
		// the VList<ViewPhanNhomLopHocPhan> instance used to test the repository.
		private VList<ViewPhanNhomLopHocPhan> mockCollection;		

        /// <summary>
		/// This method is used to construct the test environment prior to running the tests.
		/// </summary>
        static private void Init_Generated()
        {
			System.Console.WriteLine(new String('-', 75));
			System.Console.WriteLine("-- Testing the ViewPhanNhomLopHocPhan Entity with the {0} --", PMS.Data.DataRepository.Provider.Name);
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
		/// Selects a page of ViewPhanNhomLopHocPhan objects from the database.
		/// </summary>
		private void Step_1_SelectAll_Generated()
		{
			int count = -1;
			mockCollection = DataRepository.ViewPhanNhomLopHocPhanProvider.GetPaged(null, 0, 10, out count);
			Assert.IsTrue(count >= 0, "Select Query Failed with GetPaged");
			System.Console.WriteLine("DataRepository.ViewPhanNhomLopHocPhanProvider.GetPaged():");			
			System.Console.WriteLine(mockCollection);			
		}
		
		/// <summary>
		/// Searches some ViewPhanNhomLopHocPhan objects from the database.
		/// </summary>
		private void Step_2_Search_Generated()
		{
			int count = -1;
			mockCollection = DataRepository.ViewPhanNhomLopHocPhanProvider.Find(null, null, "", 0, 10, out count);
			Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue Find Command.");
			
			System.Console.WriteLine("DataRepository.ViewPhanNhomLopHocPhanProvider.Find():");			
			System.Console.WriteLine(mockCollection);
					
		}
		 //Find
			
		
		#region Serialization tests
		
		/// <summary>
		/// Serialize the mock ViewPhanNhomLopHocPhan entity into a temporary file.
		/// </summary>
		private void Step_6_SerializeEntity_Generated()
		{
			string fileName = "temp_ViewPhanNhomLopHocPhan.xml";
		
			XmlSerializer mySerializer = new XmlSerializer(typeof(ViewPhanNhomLopHocPhan)); 
			System.IO.StreamWriter myWriter = new System.IO.StreamWriter(fileName); 
			mySerializer.Serialize(myWriter, mock); 
			myWriter.Close();
			System.Console.WriteLine("mock correctly serialized to a temporary file.");			
		}
		
		/// <summary>
		/// Deserialize the mock ViewPhanNhomLopHocPhan entity from a temporary file.
		/// </summary>
		private void Step_7_DeserializeEntity_Generated()
		{
			string fileName = "temp_ViewPhanNhomLopHocPhan.xml";
		
			XmlSerializer mySerializer = new XmlSerializer(typeof(ViewPhanNhomLopHocPhan)); 
			System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open); 
			mock = (ViewPhanNhomLopHocPhan) mySerializer.Deserialize(myFileStream);
			myFileStream.Close();
			System.IO.File.Delete(fileName);
			
			System.Console.WriteLine("mock correctly deserialized from a temporary file.");
		}
		
		/// <summary>
		/// Serialize a ViewPhanNhomLopHocPhan collection into a temporary file.
		/// </summary>
		private void Step_8_SerializeCollection_Generated()
		{
			string fileName = "temp_ViewPhanNhomLopHocPhanCollection.xml";
		
			VList<ViewPhanNhomLopHocPhan> mockCollection = new VList<ViewPhanNhomLopHocPhan>();
			mockCollection.Add(mock);
		
			XmlSerializer mySerializer = new XmlSerializer(typeof(VList<ViewPhanNhomLopHocPhan>)); 
			System.IO.StreamWriter myWriter = new System.IO.StreamWriter(fileName); 
			mySerializer.Serialize(myWriter, mockCollection); 
			myWriter.Close();
			
			System.Console.WriteLine("VList<ViewPhanNhomLopHocPhan> correctly serialized to a temporary file.");					
		}
		
		
		/// <summary>
		/// Deserialize a ViewPhanNhomLopHocPhan collection from a temporary file.
		/// </summary>
		private void Step_9_DeserializeCollection_Generated()
		{
			string fileName = "temp_ViewPhanNhomLopHocPhanCollection.xml";
		
			XmlSerializer mySerializer = new XmlSerializer(typeof(VList<ViewPhanNhomLopHocPhan>)); 
			System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open); 
			VList<ViewPhanNhomLopHocPhan> mockCollection = (VList<ViewPhanNhomLopHocPhan>) mySerializer.Deserialize(myFileStream);
			myFileStream.Close();
			System.IO.File.Delete(fileName);
			System.Console.WriteLine("VList<ViewPhanNhomLopHocPhan> correctly deserialized from a temporary file.");	
		}
		#endregion
		
		#region Mock Instance
		///<summary>
		///  Returns a Typed ViewPhanNhomLopHocPhan Entity with mock values.
		///</summary>
		static public ViewPhanNhomLopHocPhan CreateMockInstance()
		{		
			ViewPhanNhomLopHocPhan mock = new ViewPhanNhomLopHocPhan();
						
			mock.Id = TestUtility.Instance.RandomNumber();
			mock.MaMonHoc = TestUtility.Instance.RandomString(20, false);;
			mock.TenMonHoc = TestUtility.Instance.RandomString(126, false);;
			mock.NhomMonHoc = TestUtility.Instance.RandomString(20, false);;
			mock.NamHoc = TestUtility.Instance.RandomString(20, false);;
			mock.HocKy = TestUtility.Instance.RandomString(20, false);;
			mock.MaLopHocPhan = TestUtility.Instance.RandomString(20, false);;
			mock.MaLop = TestUtility.Instance.RandomString(99, false);;
			mock.MaGiangVienQuanLy = TestUtility.Instance.RandomString(20, false);;
			mock.HoTen = TestUtility.Instance.RandomString(75, false);;
			mock.SoTinChi = TestUtility.Instance.RandomNumber();
			mock.SiSo = TestUtility.Instance.RandomNumber();
			mock.SoTiet = TestUtility.Instance.RandomNumber();
			mock.MaKhoa = TestUtility.Instance.RandomString(20, false);;
			mock.TenKhoa = TestUtility.Instance.RandomString(126, false);;
			mock.MaLoaiHocPhan = TestUtility.Instance.RandomNumber();
			mock.MaNhomMon = TestUtility.Instance.RandomNumber();
		   return (ViewPhanNhomLopHocPhan)mock;
		}
		

		#endregion
    }
}
