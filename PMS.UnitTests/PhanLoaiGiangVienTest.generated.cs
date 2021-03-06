﻿
/*
	File Generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file PhanLoaiGiangVienTest.cs instead.
*/

#region Using directives

using System;
using System.Xml;
using System.Xml.Serialization;
using NUnit.Framework;
using PMS.Entities;
using PMS.Data;
using PMS.Data.Bases;

#endregion

namespace PMS.UnitTests
{
    /// <summary>
    /// Provides tests for the and <see cref="PhanLoaiGiangVien"/> objects (entity, collection and repository).
    /// </summary>
   public partial class PhanLoaiGiangVienTest
    {
    	// the PhanLoaiGiangVien instance used to test the repository.
		protected PhanLoaiGiangVien mock;
		
		// the TList<PhanLoaiGiangVien> instance used to test the repository.
		protected TList<PhanLoaiGiangVien> mockCollection;
		
		protected static TransactionManager CreateTransaction()
		{
			TransactionManager transactionManager = null;
			if (DataRepository.Provider.IsTransactionSupported)
			{
				transactionManager = DataRepository.Provider.CreateTransaction();
				transactionManager.BeginTransaction(System.Data.IsolationLevel.ReadCommitted);
			}			
			return transactionManager;
		}
		       
        /// <summary>
		/// This method is used to construct the test environment prior to running the tests.
		/// </summary>        
        static public void Init_Generated()
        {		
        	System.Console.WriteLine(new String('-', 75));
			System.Console.WriteLine("-- Testing the PhanLoaiGiangVien Entity with the {0} --", PMS.Data.DataRepository.Provider.Name);
			System.Console.WriteLine(new String('-', 75));
        }
    
    	/// <summary>
		/// This method is used to restore the environment after the tests are completed.
		/// </summary>
		static public void CleanUp_Generated()
        {   		
			System.Console.WriteLine("All Tests Completed");
			System.Console.WriteLine();
        }
    
    
		/// <summary>
		/// Inserts a mock PhanLoaiGiangVien entity into the database.
		/// </summary>
		private void Step_01_Insert_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.PhanLoaiGiangVienProvider.Insert(tm, mock), "Insert failed");
										
				System.Console.WriteLine("DataRepository.PhanLoaiGiangVienProvider.Insert(mock):");			
				System.Console.WriteLine(mock);			
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Selects all PhanLoaiGiangVien objects of the database.
		/// </summary>
		private void Step_02_SelectAll_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				//Find
				int count = -1;
				
				mockCollection = DataRepository.PhanLoaiGiangVienProvider.Find(tm, null, "", 0, 10, out count );
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue Find Command.");
				
				System.Console.WriteLine("DataRepository.PhanLoaiGiangVienProvider.Find():");			
				System.Console.WriteLine(mockCollection);
				
				// GetPaged
				count = -1;
				
				mockCollection = DataRepository.PhanLoaiGiangVienProvider.GetPaged(tm, 0, 10, out count);
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue GetPaged Command.");
				System.Console.WriteLine("#get paged count: " + count.ToString());
			}
		}
		
		
		
		
		/// <summary>
		/// Deep load all PhanLoaiGiangVien children.
		/// </summary>
		private void Step_03_DeepLoad_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				int count = -1;
				mock =  CreateMockInstance(tm);
				mockCollection = DataRepository.PhanLoaiGiangVienProvider.GetPaged(tm, 0, 10, out count);
			
				DataRepository.PhanLoaiGiangVienProvider.DeepLoading += new EntityProviderBaseCore<PhanLoaiGiangVien, PhanLoaiGiangVienKey>.DeepLoadingEventHandler(
						delegate(object sender, DeepSessionEventArgs e)
						{
							if (e.DeepSession.Count > 3)
								e.Cancel = true;
						}
					);

				if (mockCollection.Count > 0)
				{
					
					DataRepository.PhanLoaiGiangVienProvider.DeepLoad(tm, mockCollection[0]);
					System.Console.WriteLine("PhanLoaiGiangVien instance correctly deep loaded at 1 level.");
									
					mockCollection.Add(mock);
					// DataRepository.PhanLoaiGiangVienProvider.DeepSave(tm, mockCollection);
				}
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		/// <summary>
		/// Updates a mock PhanLoaiGiangVien entity into the database.
		/// </summary>
		private void Step_04_Update_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				PhanLoaiGiangVien mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.PhanLoaiGiangVienProvider.Insert(tm, mock), "Insert failed");
				
				UpdateMockInstance(tm, mock);
				Assert.IsTrue(DataRepository.PhanLoaiGiangVienProvider.Update(tm, mock), "Update failed.");			
				
				System.Console.WriteLine("DataRepository.PhanLoaiGiangVienProvider.Update(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Delete the mock PhanLoaiGiangVien entity into the database.
		/// </summary>
		private void Step_05_Delete_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  (PhanLoaiGiangVien)CreateMockInstance(tm);
				DataRepository.PhanLoaiGiangVienProvider.Insert(tm, mock);
			
				Assert.IsTrue(DataRepository.PhanLoaiGiangVienProvider.Delete(tm, mock), "Delete failed.");
				System.Console.WriteLine("DataRepository.PhanLoaiGiangVienProvider.Delete(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		#region Serialization tests
		
		/// <summary>
		/// Serialize the mock PhanLoaiGiangVien entity into a temporary file.
		/// </summary>
		private void Step_06_SerializeEntity_Generated()
		{	
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  CreateMockInstance(tm);
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_PhanLoaiGiangVien.xml");
			
				EntityHelper.SerializeXml(mock, fileName);
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock not found");
					
				System.Console.WriteLine("mock correctly serialized to a temporary file.");			
			}
		}
		
		/// <summary>
		/// Deserialize the mock PhanLoaiGiangVien entity from a temporary file.
		/// </summary>
		private void Step_07_DeserializeEntity_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_PhanLoaiGiangVien.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			using (System.IO.StreamReader sr = System.IO.File.OpenText(fileName))
			{
				object item = EntityHelper.DeserializeEntityXml<PhanLoaiGiangVien>(sr.ReadToEnd());
				sr.Close();
			}
			System.IO.File.Delete(fileName);
			
			System.Console.WriteLine("mock correctly deserialized from a temporary file.");
		}
		
		/// <summary>
		/// Serialize a PhanLoaiGiangVien collection into a temporary file.
		/// </summary>
		private void Step_08_SerializeCollection_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_PhanLoaiGiangVienCollection.xml");
				
				mock = CreateMockInstance(tm);
				TList<PhanLoaiGiangVien> mockCollection = new TList<PhanLoaiGiangVien>();
				mockCollection.Add(mock);
			
				EntityHelper.SerializeXml(mockCollection, fileName);
				
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock collection not found");
				System.Console.WriteLine("TList<PhanLoaiGiangVien> correctly serialized to a temporary file.");					
			}
		}
		
		
		/// <summary>
		/// Deserialize a PhanLoaiGiangVien collection from a temporary file.
		/// </summary>
		private void Step_09_DeserializeCollection_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_PhanLoaiGiangVienCollection.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			XmlSerializer mySerializer = new XmlSerializer(typeof(TList<PhanLoaiGiangVien>)); 
			using (System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open))
			{
				TList<PhanLoaiGiangVien> mockCollection = (TList<PhanLoaiGiangVien>) mySerializer.Deserialize(myFileStream);
				myFileStream.Close();
			}
			
			System.IO.File.Delete(fileName);
			System.Console.WriteLine("TList<PhanLoaiGiangVien> correctly deserialized from a temporary file.");	
		}
		#endregion
		
		
		
		/// <summary>
		/// Check the foreign key dal methods.
		/// </summary>
		private void Step_10_FK_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				PhanLoaiGiangVien entity = CreateMockInstance(tm);
				bool result = DataRepository.PhanLoaiGiangVienProvider.Insert(tm, entity);
				
				Assert.IsTrue(result, "Could Not Test FK, Insert Failed");
				
			}
		}
		
		
		/// <summary>
		/// Check the indexes dal methods.
		/// </summary>
		private void Step_11_IX_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				PhanLoaiGiangVien entity = CreateMockInstance(tm);
				bool result = DataRepository.PhanLoaiGiangVienProvider.Insert(tm, entity);
				
				Assert.IsTrue(result, "Could Not Test IX, Insert Failed");

			
				PhanLoaiGiangVien t0 = DataRepository.PhanLoaiGiangVienProvider.GetById(tm, entity.Id);
			}
		}
		
		/// <summary>
		/// Test methods exposed by the EntityHelper class.
		/// </summary>
		private void Step_20_TestEntityHelper_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock = CreateMockInstance(tm);
				
				PhanLoaiGiangVien entity = mock.Copy() as PhanLoaiGiangVien;
				entity = (PhanLoaiGiangVien)mock.Clone();
				Assert.IsTrue(PhanLoaiGiangVien.ValueEquals(entity, mock), "Clone is not working");
			}
		}
		
		/// <summary>
		/// Test Find using the Query class
		/// </summary>
		private void Step_30_TestFindByQuery_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				//Insert Mock Instance
				PhanLoaiGiangVien mock = CreateMockInstance(tm);
				bool result = DataRepository.PhanLoaiGiangVienProvider.Insert(tm, mock);
				
				Assert.IsTrue(result, "Could Not Test FindByQuery, Insert Failed");

				PhanLoaiGiangVienQuery query = new PhanLoaiGiangVienQuery();
			
				query.AppendEquals(PhanLoaiGiangVienColumn.Id, mock.Id.ToString());
				if(mock.MaGiangVien != null)
					query.AppendEquals(PhanLoaiGiangVienColumn.MaGiangVien, mock.MaGiangVien.ToString());
				if(mock.PhanLoai != null)
					query.AppendEquals(PhanLoaiGiangVienColumn.PhanLoai, mock.PhanLoai.ToString());
				if(mock.NamHoc != null)
					query.AppendEquals(PhanLoaiGiangVienColumn.NamHoc, mock.NamHoc.ToString());
				if(mock.HocKy != null)
					query.AppendEquals(PhanLoaiGiangVienColumn.HocKy, mock.HocKy.ToString());
				if(mock.NgayCapNhat != null)
					query.AppendEquals(PhanLoaiGiangVienColumn.NgayCapNhat, mock.NgayCapNhat.ToString());
				if(mock.NguoiCapNhat != null)
					query.AppendEquals(PhanLoaiGiangVienColumn.NguoiCapNhat, mock.NguoiCapNhat.ToString());
				
				TList<PhanLoaiGiangVien> results = DataRepository.PhanLoaiGiangVienProvider.Find(tm, query);
				
				Assert.IsTrue(results.Count == 1, "Find is not working correctly.  Failed to find the mock instance");
			}
		}
						
		#region Mock Instance
		///<summary>
		///  Returns a Typed PhanLoaiGiangVien Entity with mock values.
		///</summary>
		static public PhanLoaiGiangVien CreateMockInstance_Generated(TransactionManager tm)
		{		
			PhanLoaiGiangVien mock = new PhanLoaiGiangVien();
						
			mock.MaGiangVien = TestUtility.Instance.RandomNumber();
			mock.PhanLoai = TestUtility.Instance.RandomString(9, false);;
			mock.NamHoc = TestUtility.Instance.RandomString(9, false);;
			mock.HocKy = TestUtility.Instance.RandomString(9, false);;
			mock.NgayCapNhat = TestUtility.Instance.RandomString(24, false);;
			mock.NguoiCapNhat = TestUtility.Instance.RandomString(24, false);;
			
		
			// create a temporary collection and add the item to it
			TList<PhanLoaiGiangVien> tempMockCollection = new TList<PhanLoaiGiangVien>();
			tempMockCollection.Add(mock);
			tempMockCollection.Remove(mock);
			
		
		   return (PhanLoaiGiangVien)mock;
		}
		
		
		///<summary>
		///  Update the Typed PhanLoaiGiangVien Entity with modified mock values.
		///</summary>
		static public void UpdateMockInstance_Generated(TransactionManager tm, PhanLoaiGiangVien mock)
		{
			mock.MaGiangVien = TestUtility.Instance.RandomNumber();
			mock.PhanLoai = TestUtility.Instance.RandomString(9, false);;
			mock.NamHoc = TestUtility.Instance.RandomString(9, false);;
			mock.HocKy = TestUtility.Instance.RandomString(9, false);;
			mock.NgayCapNhat = TestUtility.Instance.RandomString(24, false);;
			mock.NguoiCapNhat = TestUtility.Instance.RandomString(24, false);;
			
		}
		#endregion
    }
}
