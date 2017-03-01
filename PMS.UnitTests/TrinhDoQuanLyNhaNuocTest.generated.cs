﻿
/*
	File Generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file TrinhDoQuanLyNhaNuocTest.cs instead.
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
    /// Provides tests for the and <see cref="TrinhDoQuanLyNhaNuoc"/> objects (entity, collection and repository).
    /// </summary>
   public partial class TrinhDoQuanLyNhaNuocTest
    {
    	// the TrinhDoQuanLyNhaNuoc instance used to test the repository.
		protected TrinhDoQuanLyNhaNuoc mock;
		
		// the TList<TrinhDoQuanLyNhaNuoc> instance used to test the repository.
		protected TList<TrinhDoQuanLyNhaNuoc> mockCollection;
		
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
			System.Console.WriteLine("-- Testing the TrinhDoQuanLyNhaNuoc Entity with the {0} --", PMS.Data.DataRepository.Provider.Name);
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
		/// Inserts a mock TrinhDoQuanLyNhaNuoc entity into the database.
		/// </summary>
		private void Step_01_Insert_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.TrinhDoQuanLyNhaNuocProvider.Insert(tm, mock), "Insert failed");
										
				System.Console.WriteLine("DataRepository.TrinhDoQuanLyNhaNuocProvider.Insert(mock):");			
				System.Console.WriteLine(mock);			
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Selects all TrinhDoQuanLyNhaNuoc objects of the database.
		/// </summary>
		private void Step_02_SelectAll_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				//Find
				int count = -1;
				
				mockCollection = DataRepository.TrinhDoQuanLyNhaNuocProvider.Find(tm, null, "", 0, 10, out count );
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue Find Command.");
				
				System.Console.WriteLine("DataRepository.TrinhDoQuanLyNhaNuocProvider.Find():");			
				System.Console.WriteLine(mockCollection);
				
				// GetPaged
				count = -1;
				
				mockCollection = DataRepository.TrinhDoQuanLyNhaNuocProvider.GetPaged(tm, 0, 10, out count);
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue GetPaged Command.");
				System.Console.WriteLine("#get paged count: " + count.ToString());
			}
		}
		
		
		
		
		/// <summary>
		/// Deep load all TrinhDoQuanLyNhaNuoc children.
		/// </summary>
		private void Step_03_DeepLoad_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				int count = -1;
				mock =  CreateMockInstance(tm);
				mockCollection = DataRepository.TrinhDoQuanLyNhaNuocProvider.GetPaged(tm, 0, 10, out count);
			
				DataRepository.TrinhDoQuanLyNhaNuocProvider.DeepLoading += new EntityProviderBaseCore<TrinhDoQuanLyNhaNuoc, TrinhDoQuanLyNhaNuocKey>.DeepLoadingEventHandler(
						delegate(object sender, DeepSessionEventArgs e)
						{
							if (e.DeepSession.Count > 3)
								e.Cancel = true;
						}
					);

				if (mockCollection.Count > 0)
				{
					
					DataRepository.TrinhDoQuanLyNhaNuocProvider.DeepLoad(tm, mockCollection[0]);
					System.Console.WriteLine("TrinhDoQuanLyNhaNuoc instance correctly deep loaded at 1 level.");
									
					mockCollection.Add(mock);
					// DataRepository.TrinhDoQuanLyNhaNuocProvider.DeepSave(tm, mockCollection);
				}
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		/// <summary>
		/// Updates a mock TrinhDoQuanLyNhaNuoc entity into the database.
		/// </summary>
		private void Step_04_Update_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				TrinhDoQuanLyNhaNuoc mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.TrinhDoQuanLyNhaNuocProvider.Insert(tm, mock), "Insert failed");
				
				UpdateMockInstance(tm, mock);
				Assert.IsTrue(DataRepository.TrinhDoQuanLyNhaNuocProvider.Update(tm, mock), "Update failed.");			
				
				System.Console.WriteLine("DataRepository.TrinhDoQuanLyNhaNuocProvider.Update(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Delete the mock TrinhDoQuanLyNhaNuoc entity into the database.
		/// </summary>
		private void Step_05_Delete_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  (TrinhDoQuanLyNhaNuoc)CreateMockInstance(tm);
				DataRepository.TrinhDoQuanLyNhaNuocProvider.Insert(tm, mock);
			
				Assert.IsTrue(DataRepository.TrinhDoQuanLyNhaNuocProvider.Delete(tm, mock), "Delete failed.");
				System.Console.WriteLine("DataRepository.TrinhDoQuanLyNhaNuocProvider.Delete(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		#region Serialization tests
		
		/// <summary>
		/// Serialize the mock TrinhDoQuanLyNhaNuoc entity into a temporary file.
		/// </summary>
		private void Step_06_SerializeEntity_Generated()
		{	
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  CreateMockInstance(tm);
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_TrinhDoQuanLyNhaNuoc.xml");
			
				EntityHelper.SerializeXml(mock, fileName);
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock not found");
					
				System.Console.WriteLine("mock correctly serialized to a temporary file.");			
			}
		}
		
		/// <summary>
		/// Deserialize the mock TrinhDoQuanLyNhaNuoc entity from a temporary file.
		/// </summary>
		private void Step_07_DeserializeEntity_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_TrinhDoQuanLyNhaNuoc.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			using (System.IO.StreamReader sr = System.IO.File.OpenText(fileName))
			{
				object item = EntityHelper.DeserializeEntityXml<TrinhDoQuanLyNhaNuoc>(sr.ReadToEnd());
				sr.Close();
			}
			System.IO.File.Delete(fileName);
			
			System.Console.WriteLine("mock correctly deserialized from a temporary file.");
		}
		
		/// <summary>
		/// Serialize a TrinhDoQuanLyNhaNuoc collection into a temporary file.
		/// </summary>
		private void Step_08_SerializeCollection_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_TrinhDoQuanLyNhaNuocCollection.xml");
				
				mock = CreateMockInstance(tm);
				TList<TrinhDoQuanLyNhaNuoc> mockCollection = new TList<TrinhDoQuanLyNhaNuoc>();
				mockCollection.Add(mock);
			
				EntityHelper.SerializeXml(mockCollection, fileName);
				
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock collection not found");
				System.Console.WriteLine("TList<TrinhDoQuanLyNhaNuoc> correctly serialized to a temporary file.");					
			}
		}
		
		
		/// <summary>
		/// Deserialize a TrinhDoQuanLyNhaNuoc collection from a temporary file.
		/// </summary>
		private void Step_09_DeserializeCollection_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_TrinhDoQuanLyNhaNuocCollection.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			XmlSerializer mySerializer = new XmlSerializer(typeof(TList<TrinhDoQuanLyNhaNuoc>)); 
			using (System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open))
			{
				TList<TrinhDoQuanLyNhaNuoc> mockCollection = (TList<TrinhDoQuanLyNhaNuoc>) mySerializer.Deserialize(myFileStream);
				myFileStream.Close();
			}
			
			System.IO.File.Delete(fileName);
			System.Console.WriteLine("TList<TrinhDoQuanLyNhaNuoc> correctly deserialized from a temporary file.");	
		}
		#endregion
		
		
		
		/// <summary>
		/// Check the foreign key dal methods.
		/// </summary>
		private void Step_10_FK_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				TrinhDoQuanLyNhaNuoc entity = CreateMockInstance(tm);
				bool result = DataRepository.TrinhDoQuanLyNhaNuocProvider.Insert(tm, entity);
				
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
				TrinhDoQuanLyNhaNuoc entity = CreateMockInstance(tm);
				bool result = DataRepository.TrinhDoQuanLyNhaNuocProvider.Insert(tm, entity);
				
				Assert.IsTrue(result, "Could Not Test IX, Insert Failed");

			
				TrinhDoQuanLyNhaNuoc t0 = DataRepository.TrinhDoQuanLyNhaNuocProvider.GetByMaTrinhDoQuanLyNhaNuoc(tm, entity.MaTrinhDoQuanLyNhaNuoc);
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
				
				TrinhDoQuanLyNhaNuoc entity = mock.Copy() as TrinhDoQuanLyNhaNuoc;
				entity = (TrinhDoQuanLyNhaNuoc)mock.Clone();
				Assert.IsTrue(TrinhDoQuanLyNhaNuoc.ValueEquals(entity, mock), "Clone is not working");
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
				TrinhDoQuanLyNhaNuoc mock = CreateMockInstance(tm);
				bool result = DataRepository.TrinhDoQuanLyNhaNuocProvider.Insert(tm, mock);
				
				Assert.IsTrue(result, "Could Not Test FindByQuery, Insert Failed");

				TrinhDoQuanLyNhaNuocQuery query = new TrinhDoQuanLyNhaNuocQuery();
			
				query.AppendEquals(TrinhDoQuanLyNhaNuocColumn.MaTrinhDoQuanLyNhaNuoc, mock.MaTrinhDoQuanLyNhaNuoc.ToString());
				if(mock.MaQuanLy != null)
					query.AppendEquals(TrinhDoQuanLyNhaNuocColumn.MaQuanLy, mock.MaQuanLy.ToString());
				if(mock.TenTrinhDoQuanLyNhaNuoc != null)
					query.AppendEquals(TrinhDoQuanLyNhaNuocColumn.TenTrinhDoQuanLyNhaNuoc, mock.TenTrinhDoQuanLyNhaNuoc.ToString());
				if(mock.GhiChu != null)
					query.AppendEquals(TrinhDoQuanLyNhaNuocColumn.GhiChu, mock.GhiChu.ToString());
				if(mock.NgayCapNhat != null)
					query.AppendEquals(TrinhDoQuanLyNhaNuocColumn.NgayCapNhat, mock.NgayCapNhat.ToString());
				if(mock.NguoiCapNhat != null)
					query.AppendEquals(TrinhDoQuanLyNhaNuocColumn.NguoiCapNhat, mock.NguoiCapNhat.ToString());
				
				TList<TrinhDoQuanLyNhaNuoc> results = DataRepository.TrinhDoQuanLyNhaNuocProvider.Find(tm, query);
				
				Assert.IsTrue(results.Count == 1, "Find is not working correctly.  Failed to find the mock instance");
			}
		}
						
		#region Mock Instance
		///<summary>
		///  Returns a Typed TrinhDoQuanLyNhaNuoc Entity with mock values.
		///</summary>
		static public TrinhDoQuanLyNhaNuoc CreateMockInstance_Generated(TransactionManager tm)
		{		
			TrinhDoQuanLyNhaNuoc mock = new TrinhDoQuanLyNhaNuoc();
						
			mock.MaQuanLy = TestUtility.Instance.RandomString(9, false);;
			mock.TenTrinhDoQuanLyNhaNuoc = TestUtility.Instance.RandomString(249, false);;
			mock.GhiChu = TestUtility.Instance.RandomString(249, false);;
			mock.NgayCapNhat = TestUtility.Instance.RandomString(24, false);;
			mock.NguoiCapNhat = TestUtility.Instance.RandomString(24, false);;
			
		
			// create a temporary collection and add the item to it
			TList<TrinhDoQuanLyNhaNuoc> tempMockCollection = new TList<TrinhDoQuanLyNhaNuoc>();
			tempMockCollection.Add(mock);
			tempMockCollection.Remove(mock);
			
		
		   return (TrinhDoQuanLyNhaNuoc)mock;
		}
		
		
		///<summary>
		///  Update the Typed TrinhDoQuanLyNhaNuoc Entity with modified mock values.
		///</summary>
		static public void UpdateMockInstance_Generated(TransactionManager tm, TrinhDoQuanLyNhaNuoc mock)
		{
			mock.MaQuanLy = TestUtility.Instance.RandomString(9, false);;
			mock.TenTrinhDoQuanLyNhaNuoc = TestUtility.Instance.RandomString(249, false);;
			mock.GhiChu = TestUtility.Instance.RandomString(249, false);;
			mock.NgayCapNhat = TestUtility.Instance.RandomString(24, false);;
			mock.NguoiCapNhat = TestUtility.Instance.RandomString(24, false);;
			
		}
		#endregion
    }
}
