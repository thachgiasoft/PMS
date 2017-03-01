﻿
/*
	File Generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file TienCongTacPhiTest.cs instead.
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
    /// Provides tests for the and <see cref="TienCongTacPhi"/> objects (entity, collection and repository).
    /// </summary>
   public partial class TienCongTacPhiTest
    {
    	// the TienCongTacPhi instance used to test the repository.
		protected TienCongTacPhi mock;
		
		// the TList<TienCongTacPhi> instance used to test the repository.
		protected TList<TienCongTacPhi> mockCollection;
		
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
			System.Console.WriteLine("-- Testing the TienCongTacPhi Entity with the {0} --", PMS.Data.DataRepository.Provider.Name);
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
		/// Inserts a mock TienCongTacPhi entity into the database.
		/// </summary>
		private void Step_01_Insert_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.TienCongTacPhiProvider.Insert(tm, mock), "Insert failed");
										
				System.Console.WriteLine("DataRepository.TienCongTacPhiProvider.Insert(mock):");			
				System.Console.WriteLine(mock);			
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Selects all TienCongTacPhi objects of the database.
		/// </summary>
		private void Step_02_SelectAll_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				//Find
				int count = -1;
				
				mockCollection = DataRepository.TienCongTacPhiProvider.Find(tm, null, "", 0, 10, out count );
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue Find Command.");
				
				System.Console.WriteLine("DataRepository.TienCongTacPhiProvider.Find():");			
				System.Console.WriteLine(mockCollection);
				
				// GetPaged
				count = -1;
				
				mockCollection = DataRepository.TienCongTacPhiProvider.GetPaged(tm, 0, 10, out count);
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue GetPaged Command.");
				System.Console.WriteLine("#get paged count: " + count.ToString());
			}
		}
		
		
		
		
		/// <summary>
		/// Deep load all TienCongTacPhi children.
		/// </summary>
		private void Step_03_DeepLoad_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				int count = -1;
				mock =  CreateMockInstance(tm);
				mockCollection = DataRepository.TienCongTacPhiProvider.GetPaged(tm, 0, 10, out count);
			
				DataRepository.TienCongTacPhiProvider.DeepLoading += new EntityProviderBaseCore<TienCongTacPhi, TienCongTacPhiKey>.DeepLoadingEventHandler(
						delegate(object sender, DeepSessionEventArgs e)
						{
							if (e.DeepSession.Count > 3)
								e.Cancel = true;
						}
					);

				if (mockCollection.Count > 0)
				{
					
					DataRepository.TienCongTacPhiProvider.DeepLoad(tm, mockCollection[0]);
					System.Console.WriteLine("TienCongTacPhi instance correctly deep loaded at 1 level.");
									
					mockCollection.Add(mock);
					// DataRepository.TienCongTacPhiProvider.DeepSave(tm, mockCollection);
				}
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		/// <summary>
		/// Updates a mock TienCongTacPhi entity into the database.
		/// </summary>
		private void Step_04_Update_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				TienCongTacPhi mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.TienCongTacPhiProvider.Insert(tm, mock), "Insert failed");
				
				UpdateMockInstance(tm, mock);
				Assert.IsTrue(DataRepository.TienCongTacPhiProvider.Update(tm, mock), "Update failed.");			
				
				System.Console.WriteLine("DataRepository.TienCongTacPhiProvider.Update(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Delete the mock TienCongTacPhi entity into the database.
		/// </summary>
		private void Step_05_Delete_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  (TienCongTacPhi)CreateMockInstance(tm);
				DataRepository.TienCongTacPhiProvider.Insert(tm, mock);
			
				Assert.IsTrue(DataRepository.TienCongTacPhiProvider.Delete(tm, mock), "Delete failed.");
				System.Console.WriteLine("DataRepository.TienCongTacPhiProvider.Delete(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		#region Serialization tests
		
		/// <summary>
		/// Serialize the mock TienCongTacPhi entity into a temporary file.
		/// </summary>
		private void Step_06_SerializeEntity_Generated()
		{	
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  CreateMockInstance(tm);
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_TienCongTacPhi.xml");
			
				EntityHelper.SerializeXml(mock, fileName);
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock not found");
					
				System.Console.WriteLine("mock correctly serialized to a temporary file.");			
			}
		}
		
		/// <summary>
		/// Deserialize the mock TienCongTacPhi entity from a temporary file.
		/// </summary>
		private void Step_07_DeserializeEntity_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_TienCongTacPhi.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			using (System.IO.StreamReader sr = System.IO.File.OpenText(fileName))
			{
				object item = EntityHelper.DeserializeEntityXml<TienCongTacPhi>(sr.ReadToEnd());
				sr.Close();
			}
			System.IO.File.Delete(fileName);
			
			System.Console.WriteLine("mock correctly deserialized from a temporary file.");
		}
		
		/// <summary>
		/// Serialize a TienCongTacPhi collection into a temporary file.
		/// </summary>
		private void Step_08_SerializeCollection_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_TienCongTacPhiCollection.xml");
				
				mock = CreateMockInstance(tm);
				TList<TienCongTacPhi> mockCollection = new TList<TienCongTacPhi>();
				mockCollection.Add(mock);
			
				EntityHelper.SerializeXml(mockCollection, fileName);
				
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock collection not found");
				System.Console.WriteLine("TList<TienCongTacPhi> correctly serialized to a temporary file.");					
			}
		}
		
		
		/// <summary>
		/// Deserialize a TienCongTacPhi collection from a temporary file.
		/// </summary>
		private void Step_09_DeserializeCollection_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_TienCongTacPhiCollection.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			XmlSerializer mySerializer = new XmlSerializer(typeof(TList<TienCongTacPhi>)); 
			using (System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open))
			{
				TList<TienCongTacPhi> mockCollection = (TList<TienCongTacPhi>) mySerializer.Deserialize(myFileStream);
				myFileStream.Close();
			}
			
			System.IO.File.Delete(fileName);
			System.Console.WriteLine("TList<TienCongTacPhi> correctly deserialized from a temporary file.");	
		}
		#endregion
		
		
		
		/// <summary>
		/// Check the foreign key dal methods.
		/// </summary>
		private void Step_10_FK_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				TienCongTacPhi entity = CreateMockInstance(tm);
				bool result = DataRepository.TienCongTacPhiProvider.Insert(tm, entity);
				
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
				TienCongTacPhi entity = CreateMockInstance(tm);
				bool result = DataRepository.TienCongTacPhiProvider.Insert(tm, entity);
				
				Assert.IsTrue(result, "Could Not Test IX, Insert Failed");

			
				TienCongTacPhi t0 = DataRepository.TienCongTacPhiProvider.GetByMaCoSo(tm, entity.MaCoSo);
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
				
				TienCongTacPhi entity = mock.Copy() as TienCongTacPhi;
				entity = (TienCongTacPhi)mock.Clone();
				Assert.IsTrue(TienCongTacPhi.ValueEquals(entity, mock), "Clone is not working");
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
				TienCongTacPhi mock = CreateMockInstance(tm);
				bool result = DataRepository.TienCongTacPhiProvider.Insert(tm, mock);
				
				Assert.IsTrue(result, "Could Not Test FindByQuery, Insert Failed");

				TienCongTacPhiQuery query = new TienCongTacPhiQuery();
			
				query.AppendEquals(TienCongTacPhiColumn.MaCoSo, mock.MaCoSo.ToString());
				if(mock.TenCoSo != null)
					query.AppendEquals(TienCongTacPhiColumn.TenCoSo, mock.TenCoSo.ToString());
				if(mock.SoTien != null)
					query.AppendEquals(TienCongTacPhiColumn.SoTien, mock.SoTien.ToString());
				if(mock.GhiChu != null)
					query.AppendEquals(TienCongTacPhiColumn.GhiChu, mock.GhiChu.ToString());
				
				TList<TienCongTacPhi> results = DataRepository.TienCongTacPhiProvider.Find(tm, query);
				
				Assert.IsTrue(results.Count == 1, "Find is not working correctly.  Failed to find the mock instance");
			}
		}
						
		#region Mock Instance
		///<summary>
		///  Returns a Typed TienCongTacPhi Entity with mock values.
		///</summary>
		static public TienCongTacPhi CreateMockInstance_Generated(TransactionManager tm)
		{		
			TienCongTacPhi mock = new TienCongTacPhi();
						
			mock.MaCoSo = TestUtility.Instance.RandomString(24, false);;
			mock.TenCoSo = TestUtility.Instance.RandomString(249, false);;
			mock.SoTien = (decimal)TestUtility.Instance.RandomShort();
			mock.GhiChu = TestUtility.Instance.RandomString(249, false);;
			
		
			// create a temporary collection and add the item to it
			TList<TienCongTacPhi> tempMockCollection = new TList<TienCongTacPhi>();
			tempMockCollection.Add(mock);
			tempMockCollection.Remove(mock);
			
		
		   return (TienCongTacPhi)mock;
		}
		
		
		///<summary>
		///  Update the Typed TienCongTacPhi Entity with modified mock values.
		///</summary>
		static public void UpdateMockInstance_Generated(TransactionManager tm, TienCongTacPhi mock)
		{
			mock.TenCoSo = TestUtility.Instance.RandomString(249, false);;
			mock.SoTien = (decimal)TestUtility.Instance.RandomShort();
			mock.GhiChu = TestUtility.Instance.RandomString(249, false);;
			
		}
		#endregion
    }
}