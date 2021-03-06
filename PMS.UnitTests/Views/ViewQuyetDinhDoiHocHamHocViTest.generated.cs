﻿/*
	File Generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file ViewQuyetDinhDoiHocHamHocViTest.cs instead.
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
    /// Provides tests for the and <see cref="ViewQuyetDinhDoiHocHamHocVi"/> objects (entity, collection and repository).
    /// </summary>
    public partial class ViewQuyetDinhDoiHocHamHocViTest
    {
    	// the ViewQuyetDinhDoiHocHamHocVi instance used to test the repository.
		private ViewQuyetDinhDoiHocHamHocVi mock;
		
		// the VList<ViewQuyetDinhDoiHocHamHocVi> instance used to test the repository.
		private VList<ViewQuyetDinhDoiHocHamHocVi> mockCollection;		

        /// <summary>
		/// This method is used to construct the test environment prior to running the tests.
		/// </summary>
        static private void Init_Generated()
        {
			System.Console.WriteLine(new String('-', 75));
			System.Console.WriteLine("-- Testing the ViewQuyetDinhDoiHocHamHocVi Entity with the {0} --", PMS.Data.DataRepository.Provider.Name);
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
		/// Selects a page of ViewQuyetDinhDoiHocHamHocVi objects from the database.
		/// </summary>
		private void Step_1_SelectAll_Generated()
		{
			int count = -1;
			mockCollection = DataRepository.ViewQuyetDinhDoiHocHamHocViProvider.GetPaged(null, 0, 10, out count);
			Assert.IsTrue(count >= 0, "Select Query Failed with GetPaged");
			System.Console.WriteLine("DataRepository.ViewQuyetDinhDoiHocHamHocViProvider.GetPaged():");			
			System.Console.WriteLine(mockCollection);			
		}
		
		/// <summary>
		/// Searches some ViewQuyetDinhDoiHocHamHocVi objects from the database.
		/// </summary>
		private void Step_2_Search_Generated()
		{
			int count = -1;
			mockCollection = DataRepository.ViewQuyetDinhDoiHocHamHocViProvider.Find(null, null, "", 0, 10, out count);
			Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue Find Command.");
			
			System.Console.WriteLine("DataRepository.ViewQuyetDinhDoiHocHamHocViProvider.Find():");			
			System.Console.WriteLine(mockCollection);
					
		}
		 //Find
			
		
		#region Serialization tests
		
		/// <summary>
		/// Serialize the mock ViewQuyetDinhDoiHocHamHocVi entity into a temporary file.
		/// </summary>
		private void Step_6_SerializeEntity_Generated()
		{
			string fileName = "temp_ViewQuyetDinhDoiHocHamHocVi.xml";
		
			XmlSerializer mySerializer = new XmlSerializer(typeof(ViewQuyetDinhDoiHocHamHocVi)); 
			System.IO.StreamWriter myWriter = new System.IO.StreamWriter(fileName); 
			mySerializer.Serialize(myWriter, mock); 
			myWriter.Close();
			System.Console.WriteLine("mock correctly serialized to a temporary file.");			
		}
		
		/// <summary>
		/// Deserialize the mock ViewQuyetDinhDoiHocHamHocVi entity from a temporary file.
		/// </summary>
		private void Step_7_DeserializeEntity_Generated()
		{
			string fileName = "temp_ViewQuyetDinhDoiHocHamHocVi.xml";
		
			XmlSerializer mySerializer = new XmlSerializer(typeof(ViewQuyetDinhDoiHocHamHocVi)); 
			System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open); 
			mock = (ViewQuyetDinhDoiHocHamHocVi) mySerializer.Deserialize(myFileStream);
			myFileStream.Close();
			System.IO.File.Delete(fileName);
			
			System.Console.WriteLine("mock correctly deserialized from a temporary file.");
		}
		
		/// <summary>
		/// Serialize a ViewQuyetDinhDoiHocHamHocVi collection into a temporary file.
		/// </summary>
		private void Step_8_SerializeCollection_Generated()
		{
			string fileName = "temp_ViewQuyetDinhDoiHocHamHocViCollection.xml";
		
			VList<ViewQuyetDinhDoiHocHamHocVi> mockCollection = new VList<ViewQuyetDinhDoiHocHamHocVi>();
			mockCollection.Add(mock);
		
			XmlSerializer mySerializer = new XmlSerializer(typeof(VList<ViewQuyetDinhDoiHocHamHocVi>)); 
			System.IO.StreamWriter myWriter = new System.IO.StreamWriter(fileName); 
			mySerializer.Serialize(myWriter, mockCollection); 
			myWriter.Close();
			
			System.Console.WriteLine("VList<ViewQuyetDinhDoiHocHamHocVi> correctly serialized to a temporary file.");					
		}
		
		
		/// <summary>
		/// Deserialize a ViewQuyetDinhDoiHocHamHocVi collection from a temporary file.
		/// </summary>
		private void Step_9_DeserializeCollection_Generated()
		{
			string fileName = "temp_ViewQuyetDinhDoiHocHamHocViCollection.xml";
		
			XmlSerializer mySerializer = new XmlSerializer(typeof(VList<ViewQuyetDinhDoiHocHamHocVi>)); 
			System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open); 
			VList<ViewQuyetDinhDoiHocHamHocVi> mockCollection = (VList<ViewQuyetDinhDoiHocHamHocVi>) mySerializer.Deserialize(myFileStream);
			myFileStream.Close();
			System.IO.File.Delete(fileName);
			System.Console.WriteLine("VList<ViewQuyetDinhDoiHocHamHocVi> correctly deserialized from a temporary file.");	
		}
		#endregion
		
		#region Mock Instance
		///<summary>
		///  Returns a Typed ViewQuyetDinhDoiHocHamHocVi Entity with mock values.
		///</summary>
		static public ViewQuyetDinhDoiHocHamHocVi CreateMockInstance()
		{		
			ViewQuyetDinhDoiHocHamHocVi mock = new ViewQuyetDinhDoiHocHamHocVi();
						
			mock.MaGiangVien = TestUtility.Instance.RandomNumber();
			mock.MaCu = TestUtility.Instance.RandomNumber();
			mock.MaMoi = TestUtility.Instance.RandomNumber();
			mock.TenCu = TestUtility.Instance.RandomString(99, false);;
			mock.TenMoi = TestUtility.Instance.RandomString(99, false);;
			mock.NgayHieuLuc = TestUtility.Instance.RandomDateTime();
			mock.LoaiQuyetDinh = TestUtility.Instance.RandomString(8, false);;
		   return (ViewQuyetDinhDoiHocHamHocVi)mock;
		}
		

		#endregion
    }
}
