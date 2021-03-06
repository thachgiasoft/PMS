﻿
/*
	File Generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file DotChiTraTest.cs instead.
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
    /// Provides tests for the and <see cref="DotChiTra"/> objects (entity, collection and repository).
    /// </summary>
   public partial class DotChiTraTest
    {
    	// the DotChiTra instance used to test the repository.
		protected DotChiTra mock;
		
		// the TList<DotChiTra> instance used to test the repository.
		protected TList<DotChiTra> mockCollection;
		
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
			System.Console.WriteLine("-- Testing the DotChiTra Entity with the {0} --", PMS.Data.DataRepository.Provider.Name);
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
		/// Inserts a mock DotChiTra entity into the database.
		/// </summary>
		private void Step_01_Insert_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.DotChiTraProvider.Insert(tm, mock), "Insert failed");
										
				System.Console.WriteLine("DataRepository.DotChiTraProvider.Insert(mock):");			
				System.Console.WriteLine(mock);			
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Selects all DotChiTra objects of the database.
		/// </summary>
		private void Step_02_SelectAll_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				//Find
				int count = -1;
				
				mockCollection = DataRepository.DotChiTraProvider.Find(tm, null, "", 0, 10, out count );
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue Find Command.");
				
				System.Console.WriteLine("DataRepository.DotChiTraProvider.Find():");			
				System.Console.WriteLine(mockCollection);
				
				// GetPaged
				count = -1;
				
				mockCollection = DataRepository.DotChiTraProvider.GetPaged(tm, 0, 10, out count);
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue GetPaged Command.");
				System.Console.WriteLine("#get paged count: " + count.ToString());
			}
		}
		
		
		
		
		/// <summary>
		/// Deep load all DotChiTra children.
		/// </summary>
		private void Step_03_DeepLoad_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				int count = -1;
				mock =  CreateMockInstance(tm);
				mockCollection = DataRepository.DotChiTraProvider.GetPaged(tm, 0, 10, out count);
			
				DataRepository.DotChiTraProvider.DeepLoading += new EntityProviderBaseCore<DotChiTra, DotChiTraKey>.DeepLoadingEventHandler(
						delegate(object sender, DeepSessionEventArgs e)
						{
							if (e.DeepSession.Count > 3)
								e.Cancel = true;
						}
					);

				if (mockCollection.Count > 0)
				{
					
					DataRepository.DotChiTraProvider.DeepLoad(tm, mockCollection[0]);
					System.Console.WriteLine("DotChiTra instance correctly deep loaded at 1 level.");
									
					mockCollection.Add(mock);
					// DataRepository.DotChiTraProvider.DeepSave(tm, mockCollection);
				}
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		/// <summary>
		/// Updates a mock DotChiTra entity into the database.
		/// </summary>
		private void Step_04_Update_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				DotChiTra mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.DotChiTraProvider.Insert(tm, mock), "Insert failed");
				
				UpdateMockInstance(tm, mock);
				Assert.IsTrue(DataRepository.DotChiTraProvider.Update(tm, mock), "Update failed.");			
				
				System.Console.WriteLine("DataRepository.DotChiTraProvider.Update(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Delete the mock DotChiTra entity into the database.
		/// </summary>
		private void Step_05_Delete_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  (DotChiTra)CreateMockInstance(tm);
				DataRepository.DotChiTraProvider.Insert(tm, mock);
			
				Assert.IsTrue(DataRepository.DotChiTraProvider.Delete(tm, mock), "Delete failed.");
				System.Console.WriteLine("DataRepository.DotChiTraProvider.Delete(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		#region Serialization tests
		
		/// <summary>
		/// Serialize the mock DotChiTra entity into a temporary file.
		/// </summary>
		private void Step_06_SerializeEntity_Generated()
		{	
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  CreateMockInstance(tm);
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_DotChiTra.xml");
			
				EntityHelper.SerializeXml(mock, fileName);
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock not found");
					
				System.Console.WriteLine("mock correctly serialized to a temporary file.");			
			}
		}
		
		/// <summary>
		/// Deserialize the mock DotChiTra entity from a temporary file.
		/// </summary>
		private void Step_07_DeserializeEntity_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_DotChiTra.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			using (System.IO.StreamReader sr = System.IO.File.OpenText(fileName))
			{
				object item = EntityHelper.DeserializeEntityXml<DotChiTra>(sr.ReadToEnd());
				sr.Close();
			}
			System.IO.File.Delete(fileName);
			
			System.Console.WriteLine("mock correctly deserialized from a temporary file.");
		}
		
		/// <summary>
		/// Serialize a DotChiTra collection into a temporary file.
		/// </summary>
		private void Step_08_SerializeCollection_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_DotChiTraCollection.xml");
				
				mock = CreateMockInstance(tm);
				TList<DotChiTra> mockCollection = new TList<DotChiTra>();
				mockCollection.Add(mock);
			
				EntityHelper.SerializeXml(mockCollection, fileName);
				
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock collection not found");
				System.Console.WriteLine("TList<DotChiTra> correctly serialized to a temporary file.");					
			}
		}
		
		
		/// <summary>
		/// Deserialize a DotChiTra collection from a temporary file.
		/// </summary>
		private void Step_09_DeserializeCollection_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_DotChiTraCollection.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			XmlSerializer mySerializer = new XmlSerializer(typeof(TList<DotChiTra>)); 
			using (System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open))
			{
				TList<DotChiTra> mockCollection = (TList<DotChiTra>) mySerializer.Deserialize(myFileStream);
				myFileStream.Close();
			}
			
			System.IO.File.Delete(fileName);
			System.Console.WriteLine("TList<DotChiTra> correctly deserialized from a temporary file.");	
		}
		#endregion
		
		
		
		/// <summary>
		/// Check the foreign key dal methods.
		/// </summary>
		private void Step_10_FK_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				DotChiTra entity = CreateMockInstance(tm);
				bool result = DataRepository.DotChiTraProvider.Insert(tm, entity);
				
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
				DotChiTra entity = CreateMockInstance(tm);
				bool result = DataRepository.DotChiTraProvider.Insert(tm, entity);
				
				Assert.IsTrue(result, "Could Not Test IX, Insert Failed");

			
				DotChiTra t0 = DataRepository.DotChiTraProvider.GetById(tm, entity.Id);
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
				
				DotChiTra entity = mock.Copy() as DotChiTra;
				entity = (DotChiTra)mock.Clone();
				Assert.IsTrue(DotChiTra.ValueEquals(entity, mock), "Clone is not working");
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
				DotChiTra mock = CreateMockInstance(tm);
				bool result = DataRepository.DotChiTraProvider.Insert(tm, mock);
				
				Assert.IsTrue(result, "Could Not Test FindByQuery, Insert Failed");

				DotChiTraQuery query = new DotChiTraQuery();
			
				query.AppendEquals(DotChiTraColumn.Id, mock.Id.ToString());
				if(mock.MaDotChiTra != null)
					query.AppendEquals(DotChiTraColumn.MaDotChiTra, mock.MaDotChiTra.ToString());
				if(mock.TenDotChiTra != null)
					query.AppendEquals(DotChiTraColumn.TenDotChiTra, mock.TenDotChiTra.ToString());
				if(mock.GhiChu != null)
					query.AppendEquals(DotChiTraColumn.GhiChu, mock.GhiChu.ToString());
				if(mock.NamHoc != null)
					query.AppendEquals(DotChiTraColumn.NamHoc, mock.NamHoc.ToString());
				if(mock.HocKy != null)
					query.AppendEquals(DotChiTraColumn.HocKy, mock.HocKy.ToString());
				if(mock.ThuTu != null)
					query.AppendEquals(DotChiTraColumn.ThuTu, mock.ThuTu.ToString());
				
				TList<DotChiTra> results = DataRepository.DotChiTraProvider.Find(tm, query);
				
				Assert.IsTrue(results.Count == 1, "Find is not working correctly.  Failed to find the mock instance");
			}
		}
						
		#region Mock Instance
		///<summary>
		///  Returns a Typed DotChiTra Entity with mock values.
		///</summary>
		static public DotChiTra CreateMockInstance_Generated(TransactionManager tm)
		{		
			DotChiTra mock = new DotChiTra();
						
			mock.MaDotChiTra = TestUtility.Instance.RandomString(9, false);;
			mock.TenDotChiTra = TestUtility.Instance.RandomString(249, false);;
			mock.GhiChu = TestUtility.Instance.RandomString(249, false);;
			mock.NamHoc = TestUtility.Instance.RandomString(9, false);;
			mock.HocKy = TestUtility.Instance.RandomString(9, false);;
			mock.ThuTu = TestUtility.Instance.RandomNumber();
			
		
			// create a temporary collection and add the item to it
			TList<DotChiTra> tempMockCollection = new TList<DotChiTra>();
			tempMockCollection.Add(mock);
			tempMockCollection.Remove(mock);
			
		
		   return (DotChiTra)mock;
		}
		
		
		///<summary>
		///  Update the Typed DotChiTra Entity with modified mock values.
		///</summary>
		static public void UpdateMockInstance_Generated(TransactionManager tm, DotChiTra mock)
		{
			mock.MaDotChiTra = TestUtility.Instance.RandomString(9, false);;
			mock.TenDotChiTra = TestUtility.Instance.RandomString(249, false);;
			mock.GhiChu = TestUtility.Instance.RandomString(249, false);;
			mock.NamHoc = TestUtility.Instance.RandomString(9, false);;
			mock.HocKy = TestUtility.Instance.RandomString(9, false);;
			mock.ThuTu = TestUtility.Instance.RandomNumber();
			
		}
		#endregion
    }
}
