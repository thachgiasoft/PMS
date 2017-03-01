﻿
/*
	File Generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file DanhMucHoatDongQuanLyTest.cs instead.
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
    /// Provides tests for the and <see cref="DanhMucHoatDongQuanLy"/> objects (entity, collection and repository).
    /// </summary>
   public partial class DanhMucHoatDongQuanLyTest
    {
    	// the DanhMucHoatDongQuanLy instance used to test the repository.
		protected DanhMucHoatDongQuanLy mock;
		
		// the TList<DanhMucHoatDongQuanLy> instance used to test the repository.
		protected TList<DanhMucHoatDongQuanLy> mockCollection;
		
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
			System.Console.WriteLine("-- Testing the DanhMucHoatDongQuanLy Entity with the {0} --", PMS.Data.DataRepository.Provider.Name);
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
		/// Inserts a mock DanhMucHoatDongQuanLy entity into the database.
		/// </summary>
		private void Step_01_Insert_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.DanhMucHoatDongQuanLyProvider.Insert(tm, mock), "Insert failed");
										
				System.Console.WriteLine("DataRepository.DanhMucHoatDongQuanLyProvider.Insert(mock):");			
				System.Console.WriteLine(mock);			
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Selects all DanhMucHoatDongQuanLy objects of the database.
		/// </summary>
		private void Step_02_SelectAll_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				//Find
				int count = -1;
				
				mockCollection = DataRepository.DanhMucHoatDongQuanLyProvider.Find(tm, null, "", 0, 10, out count );
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue Find Command.");
				
				System.Console.WriteLine("DataRepository.DanhMucHoatDongQuanLyProvider.Find():");			
				System.Console.WriteLine(mockCollection);
				
				// GetPaged
				count = -1;
				
				mockCollection = DataRepository.DanhMucHoatDongQuanLyProvider.GetPaged(tm, 0, 10, out count);
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue GetPaged Command.");
				System.Console.WriteLine("#get paged count: " + count.ToString());
			}
		}
		
		
		
		
		/// <summary>
		/// Deep load all DanhMucHoatDongQuanLy children.
		/// </summary>
		private void Step_03_DeepLoad_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				int count = -1;
				mock =  CreateMockInstance(tm);
				mockCollection = DataRepository.DanhMucHoatDongQuanLyProvider.GetPaged(tm, 0, 10, out count);
			
				DataRepository.DanhMucHoatDongQuanLyProvider.DeepLoading += new EntityProviderBaseCore<DanhMucHoatDongQuanLy, DanhMucHoatDongQuanLyKey>.DeepLoadingEventHandler(
						delegate(object sender, DeepSessionEventArgs e)
						{
							if (e.DeepSession.Count > 3)
								e.Cancel = true;
						}
					);

				if (mockCollection.Count > 0)
				{
					
					DataRepository.DanhMucHoatDongQuanLyProvider.DeepLoad(tm, mockCollection[0]);
					System.Console.WriteLine("DanhMucHoatDongQuanLy instance correctly deep loaded at 1 level.");
									
					mockCollection.Add(mock);
					// DataRepository.DanhMucHoatDongQuanLyProvider.DeepSave(tm, mockCollection);
				}
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		/// <summary>
		/// Updates a mock DanhMucHoatDongQuanLy entity into the database.
		/// </summary>
		private void Step_04_Update_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				DanhMucHoatDongQuanLy mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.DanhMucHoatDongQuanLyProvider.Insert(tm, mock), "Insert failed");
				
				UpdateMockInstance(tm, mock);
				Assert.IsTrue(DataRepository.DanhMucHoatDongQuanLyProvider.Update(tm, mock), "Update failed.");			
				
				System.Console.WriteLine("DataRepository.DanhMucHoatDongQuanLyProvider.Update(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Delete the mock DanhMucHoatDongQuanLy entity into the database.
		/// </summary>
		private void Step_05_Delete_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  (DanhMucHoatDongQuanLy)CreateMockInstance(tm);
				DataRepository.DanhMucHoatDongQuanLyProvider.Insert(tm, mock);
			
				Assert.IsTrue(DataRepository.DanhMucHoatDongQuanLyProvider.Delete(tm, mock), "Delete failed.");
				System.Console.WriteLine("DataRepository.DanhMucHoatDongQuanLyProvider.Delete(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		#region Serialization tests
		
		/// <summary>
		/// Serialize the mock DanhMucHoatDongQuanLy entity into a temporary file.
		/// </summary>
		private void Step_06_SerializeEntity_Generated()
		{	
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  CreateMockInstance(tm);
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_DanhMucHoatDongQuanLy.xml");
			
				EntityHelper.SerializeXml(mock, fileName);
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock not found");
					
				System.Console.WriteLine("mock correctly serialized to a temporary file.");			
			}
		}
		
		/// <summary>
		/// Deserialize the mock DanhMucHoatDongQuanLy entity from a temporary file.
		/// </summary>
		private void Step_07_DeserializeEntity_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_DanhMucHoatDongQuanLy.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			using (System.IO.StreamReader sr = System.IO.File.OpenText(fileName))
			{
				object item = EntityHelper.DeserializeEntityXml<DanhMucHoatDongQuanLy>(sr.ReadToEnd());
				sr.Close();
			}
			System.IO.File.Delete(fileName);
			
			System.Console.WriteLine("mock correctly deserialized from a temporary file.");
		}
		
		/// <summary>
		/// Serialize a DanhMucHoatDongQuanLy collection into a temporary file.
		/// </summary>
		private void Step_08_SerializeCollection_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_DanhMucHoatDongQuanLyCollection.xml");
				
				mock = CreateMockInstance(tm);
				TList<DanhMucHoatDongQuanLy> mockCollection = new TList<DanhMucHoatDongQuanLy>();
				mockCollection.Add(mock);
			
				EntityHelper.SerializeXml(mockCollection, fileName);
				
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock collection not found");
				System.Console.WriteLine("TList<DanhMucHoatDongQuanLy> correctly serialized to a temporary file.");					
			}
		}
		
		
		/// <summary>
		/// Deserialize a DanhMucHoatDongQuanLy collection from a temporary file.
		/// </summary>
		private void Step_09_DeserializeCollection_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_DanhMucHoatDongQuanLyCollection.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			XmlSerializer mySerializer = new XmlSerializer(typeof(TList<DanhMucHoatDongQuanLy>)); 
			using (System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open))
			{
				TList<DanhMucHoatDongQuanLy> mockCollection = (TList<DanhMucHoatDongQuanLy>) mySerializer.Deserialize(myFileStream);
				myFileStream.Close();
			}
			
			System.IO.File.Delete(fileName);
			System.Console.WriteLine("TList<DanhMucHoatDongQuanLy> correctly deserialized from a temporary file.");	
		}
		#endregion
		
		
		
		/// <summary>
		/// Check the foreign key dal methods.
		/// </summary>
		private void Step_10_FK_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				DanhMucHoatDongQuanLy entity = CreateMockInstance(tm);
				bool result = DataRepository.DanhMucHoatDongQuanLyProvider.Insert(tm, entity);
				
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
				DanhMucHoatDongQuanLy entity = CreateMockInstance(tm);
				bool result = DataRepository.DanhMucHoatDongQuanLyProvider.Insert(tm, entity);
				
				Assert.IsTrue(result, "Could Not Test IX, Insert Failed");

			
				DanhMucHoatDongQuanLy t0 = DataRepository.DanhMucHoatDongQuanLyProvider.GetById(tm, entity.Id);
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
				
				DanhMucHoatDongQuanLy entity = mock.Copy() as DanhMucHoatDongQuanLy;
				entity = (DanhMucHoatDongQuanLy)mock.Clone();
				Assert.IsTrue(DanhMucHoatDongQuanLy.ValueEquals(entity, mock), "Clone is not working");
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
				DanhMucHoatDongQuanLy mock = CreateMockInstance(tm);
				bool result = DataRepository.DanhMucHoatDongQuanLyProvider.Insert(tm, mock);
				
				Assert.IsTrue(result, "Could Not Test FindByQuery, Insert Failed");

				DanhMucHoatDongQuanLyQuery query = new DanhMucHoatDongQuanLyQuery();
			
				query.AppendEquals(DanhMucHoatDongQuanLyColumn.Id, mock.Id.ToString());
				if(mock.MaHoatDong != null)
					query.AppendEquals(DanhMucHoatDongQuanLyColumn.MaHoatDong, mock.MaHoatDong.ToString());
				if(mock.TenHoatDong != null)
					query.AppendEquals(DanhMucHoatDongQuanLyColumn.TenHoatDong, mock.TenHoatDong.ToString());
				if(mock.GhiChu != null)
					query.AppendEquals(DanhMucHoatDongQuanLyColumn.GhiChu, mock.GhiChu.ToString());
				if(mock.HienThiLenWeb != null)
					query.AppendEquals(DanhMucHoatDongQuanLyColumn.HienThiLenWeb, mock.HienThiLenWeb.ToString());
				
				TList<DanhMucHoatDongQuanLy> results = DataRepository.DanhMucHoatDongQuanLyProvider.Find(tm, query);
				
				Assert.IsTrue(results.Count == 1, "Find is not working correctly.  Failed to find the mock instance");
			}
		}
						
		#region Mock Instance
		///<summary>
		///  Returns a Typed DanhMucHoatDongQuanLy Entity with mock values.
		///</summary>
		static public DanhMucHoatDongQuanLy CreateMockInstance_Generated(TransactionManager tm)
		{		
			DanhMucHoatDongQuanLy mock = new DanhMucHoatDongQuanLy();
						
			mock.MaHoatDong = TestUtility.Instance.RandomString(9, false);;
			mock.TenHoatDong = TestUtility.Instance.RandomString(249, false);;
			mock.GhiChu = TestUtility.Instance.RandomString(249, false);;
			mock.HienThiLenWeb = TestUtility.Instance.RandomBoolean();
			
		
			// create a temporary collection and add the item to it
			TList<DanhMucHoatDongQuanLy> tempMockCollection = new TList<DanhMucHoatDongQuanLy>();
			tempMockCollection.Add(mock);
			tempMockCollection.Remove(mock);
			
		
		   return (DanhMucHoatDongQuanLy)mock;
		}
		
		
		///<summary>
		///  Update the Typed DanhMucHoatDongQuanLy Entity with modified mock values.
		///</summary>
		static public void UpdateMockInstance_Generated(TransactionManager tm, DanhMucHoatDongQuanLy mock)
		{
			mock.MaHoatDong = TestUtility.Instance.RandomString(9, false);;
			mock.TenHoatDong = TestUtility.Instance.RandomString(249, false);;
			mock.GhiChu = TestUtility.Instance.RandomString(249, false);;
			mock.HienThiLenWeb = TestUtility.Instance.RandomBoolean();
			
		}
		#endregion
    }
}
