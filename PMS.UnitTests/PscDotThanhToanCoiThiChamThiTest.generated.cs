﻿
/*
	File Generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file PscDotThanhToanCoiThiChamThiTest.cs instead.
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
    /// Provides tests for the and <see cref="PscDotThanhToanCoiThiChamThi"/> objects (entity, collection and repository).
    /// </summary>
   public partial class PscDotThanhToanCoiThiChamThiTest
    {
    	// the PscDotThanhToanCoiThiChamThi instance used to test the repository.
		protected PscDotThanhToanCoiThiChamThi mock;
		
		// the TList<PscDotThanhToanCoiThiChamThi> instance used to test the repository.
		protected TList<PscDotThanhToanCoiThiChamThi> mockCollection;
		
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
			System.Console.WriteLine("-- Testing the PscDotThanhToanCoiThiChamThi Entity with the {0} --", PMS.Data.DataRepository.Provider.Name);
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
		/// Inserts a mock PscDotThanhToanCoiThiChamThi entity into the database.
		/// </summary>
		private void Step_01_Insert_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.PscDotThanhToanCoiThiChamThiProvider.Insert(tm, mock), "Insert failed");
										
				System.Console.WriteLine("DataRepository.PscDotThanhToanCoiThiChamThiProvider.Insert(mock):");			
				System.Console.WriteLine(mock);			
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Selects all PscDotThanhToanCoiThiChamThi objects of the database.
		/// </summary>
		private void Step_02_SelectAll_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				//Find
				int count = -1;
				
				mockCollection = DataRepository.PscDotThanhToanCoiThiChamThiProvider.Find(tm, null, "", 0, 10, out count );
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue Find Command.");
				
				System.Console.WriteLine("DataRepository.PscDotThanhToanCoiThiChamThiProvider.Find():");			
				System.Console.WriteLine(mockCollection);
				
				// GetPaged
				count = -1;
				
				mockCollection = DataRepository.PscDotThanhToanCoiThiChamThiProvider.GetPaged(tm, 0, 10, out count);
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue GetPaged Command.");
				System.Console.WriteLine("#get paged count: " + count.ToString());
			}
		}
		
		
		
		
		/// <summary>
		/// Deep load all PscDotThanhToanCoiThiChamThi children.
		/// </summary>
		private void Step_03_DeepLoad_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				int count = -1;
				mock =  CreateMockInstance(tm);
				mockCollection = DataRepository.PscDotThanhToanCoiThiChamThiProvider.GetPaged(tm, 0, 10, out count);
			
				DataRepository.PscDotThanhToanCoiThiChamThiProvider.DeepLoading += new EntityProviderBaseCore<PscDotThanhToanCoiThiChamThi, PscDotThanhToanCoiThiChamThiKey>.DeepLoadingEventHandler(
						delegate(object sender, DeepSessionEventArgs e)
						{
							if (e.DeepSession.Count > 3)
								e.Cancel = true;
						}
					);

				if (mockCollection.Count > 0)
				{
					
					DataRepository.PscDotThanhToanCoiThiChamThiProvider.DeepLoad(tm, mockCollection[0]);
					System.Console.WriteLine("PscDotThanhToanCoiThiChamThi instance correctly deep loaded at 1 level.");
									
					mockCollection.Add(mock);
					// DataRepository.PscDotThanhToanCoiThiChamThiProvider.DeepSave(tm, mockCollection);
				}
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		/// <summary>
		/// Updates a mock PscDotThanhToanCoiThiChamThi entity into the database.
		/// </summary>
		private void Step_04_Update_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				PscDotThanhToanCoiThiChamThi mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.PscDotThanhToanCoiThiChamThiProvider.Insert(tm, mock), "Insert failed");
				
				UpdateMockInstance(tm, mock);
				Assert.IsTrue(DataRepository.PscDotThanhToanCoiThiChamThiProvider.Update(tm, mock), "Update failed.");			
				
				System.Console.WriteLine("DataRepository.PscDotThanhToanCoiThiChamThiProvider.Update(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Delete the mock PscDotThanhToanCoiThiChamThi entity into the database.
		/// </summary>
		private void Step_05_Delete_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  (PscDotThanhToanCoiThiChamThi)CreateMockInstance(tm);
				DataRepository.PscDotThanhToanCoiThiChamThiProvider.Insert(tm, mock);
			
				Assert.IsTrue(DataRepository.PscDotThanhToanCoiThiChamThiProvider.Delete(tm, mock), "Delete failed.");
				System.Console.WriteLine("DataRepository.PscDotThanhToanCoiThiChamThiProvider.Delete(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		#region Serialization tests
		
		/// <summary>
		/// Serialize the mock PscDotThanhToanCoiThiChamThi entity into a temporary file.
		/// </summary>
		private void Step_06_SerializeEntity_Generated()
		{	
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  CreateMockInstance(tm);
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_PscDotThanhToanCoiThiChamThi.xml");
			
				EntityHelper.SerializeXml(mock, fileName);
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock not found");
					
				System.Console.WriteLine("mock correctly serialized to a temporary file.");			
			}
		}
		
		/// <summary>
		/// Deserialize the mock PscDotThanhToanCoiThiChamThi entity from a temporary file.
		/// </summary>
		private void Step_07_DeserializeEntity_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_PscDotThanhToanCoiThiChamThi.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			using (System.IO.StreamReader sr = System.IO.File.OpenText(fileName))
			{
				object item = EntityHelper.DeserializeEntityXml<PscDotThanhToanCoiThiChamThi>(sr.ReadToEnd());
				sr.Close();
			}
			System.IO.File.Delete(fileName);
			
			System.Console.WriteLine("mock correctly deserialized from a temporary file.");
		}
		
		/// <summary>
		/// Serialize a PscDotThanhToanCoiThiChamThi collection into a temporary file.
		/// </summary>
		private void Step_08_SerializeCollection_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_PscDotThanhToanCoiThiChamThiCollection.xml");
				
				mock = CreateMockInstance(tm);
				TList<PscDotThanhToanCoiThiChamThi> mockCollection = new TList<PscDotThanhToanCoiThiChamThi>();
				mockCollection.Add(mock);
			
				EntityHelper.SerializeXml(mockCollection, fileName);
				
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock collection not found");
				System.Console.WriteLine("TList<PscDotThanhToanCoiThiChamThi> correctly serialized to a temporary file.");					
			}
		}
		
		
		/// <summary>
		/// Deserialize a PscDotThanhToanCoiThiChamThi collection from a temporary file.
		/// </summary>
		private void Step_09_DeserializeCollection_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_PscDotThanhToanCoiThiChamThiCollection.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			XmlSerializer mySerializer = new XmlSerializer(typeof(TList<PscDotThanhToanCoiThiChamThi>)); 
			using (System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open))
			{
				TList<PscDotThanhToanCoiThiChamThi> mockCollection = (TList<PscDotThanhToanCoiThiChamThi>) mySerializer.Deserialize(myFileStream);
				myFileStream.Close();
			}
			
			System.IO.File.Delete(fileName);
			System.Console.WriteLine("TList<PscDotThanhToanCoiThiChamThi> correctly deserialized from a temporary file.");	
		}
		#endregion
		
		
		
		/// <summary>
		/// Check the foreign key dal methods.
		/// </summary>
		private void Step_10_FK_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				PscDotThanhToanCoiThiChamThi entity = CreateMockInstance(tm);
				bool result = DataRepository.PscDotThanhToanCoiThiChamThiProvider.Insert(tm, entity);
				
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
				PscDotThanhToanCoiThiChamThi entity = CreateMockInstance(tm);
				bool result = DataRepository.PscDotThanhToanCoiThiChamThiProvider.Insert(tm, entity);
				
				Assert.IsTrue(result, "Could Not Test IX, Insert Failed");

			
				PscDotThanhToanCoiThiChamThi t0 = DataRepository.PscDotThanhToanCoiThiChamThiProvider.GetByMaDot(tm, entity.MaDot);
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
				
				PscDotThanhToanCoiThiChamThi entity = mock.Copy() as PscDotThanhToanCoiThiChamThi;
				entity = (PscDotThanhToanCoiThiChamThi)mock.Clone();
				Assert.IsTrue(PscDotThanhToanCoiThiChamThi.ValueEquals(entity, mock), "Clone is not working");
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
				PscDotThanhToanCoiThiChamThi mock = CreateMockInstance(tm);
				bool result = DataRepository.PscDotThanhToanCoiThiChamThiProvider.Insert(tm, mock);
				
				Assert.IsTrue(result, "Could Not Test FindByQuery, Insert Failed");

				PscDotThanhToanCoiThiChamThiQuery query = new PscDotThanhToanCoiThiChamThiQuery();
			
				query.AppendEquals(PscDotThanhToanCoiThiChamThiColumn.MaDot, mock.MaDot.ToString());
				if(mock.TenDot != null)
					query.AppendEquals(PscDotThanhToanCoiThiChamThiColumn.TenDot, mock.TenDot.ToString());
				if(mock.GhiChu != null)
					query.AppendEquals(PscDotThanhToanCoiThiChamThiColumn.GhiChu, mock.GhiChu.ToString());
				
				TList<PscDotThanhToanCoiThiChamThi> results = DataRepository.PscDotThanhToanCoiThiChamThiProvider.Find(tm, query);
				
				Assert.IsTrue(results.Count == 1, "Find is not working correctly.  Failed to find the mock instance");
			}
		}
						
		#region Mock Instance
		///<summary>
		///  Returns a Typed PscDotThanhToanCoiThiChamThi Entity with mock values.
		///</summary>
		static public PscDotThanhToanCoiThiChamThi CreateMockInstance_Generated(TransactionManager tm)
		{		
			PscDotThanhToanCoiThiChamThi mock = new PscDotThanhToanCoiThiChamThi();
						
			mock.MaDot = TestUtility.Instance.RandomString(24, false);;
			mock.TenDot = TestUtility.Instance.RandomString(499, false);;
			mock.GhiChu = TestUtility.Instance.RandomString(499, false);;
			
		
			// create a temporary collection and add the item to it
			TList<PscDotThanhToanCoiThiChamThi> tempMockCollection = new TList<PscDotThanhToanCoiThiChamThi>();
			tempMockCollection.Add(mock);
			tempMockCollection.Remove(mock);
			
		
		   return (PscDotThanhToanCoiThiChamThi)mock;
		}
		
		
		///<summary>
		///  Update the Typed PscDotThanhToanCoiThiChamThi Entity with modified mock values.
		///</summary>
		static public void UpdateMockInstance_Generated(TransactionManager tm, PscDotThanhToanCoiThiChamThi mock)
		{
			mock.TenDot = TestUtility.Instance.RandomString(499, false);;
			mock.GhiChu = TestUtility.Instance.RandomString(499, false);;
			
		}
		#endregion
    }
}
