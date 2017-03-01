﻿
/*
	File Generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file PhanNhomMonHocTest.cs instead.
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
    /// Provides tests for the and <see cref="PhanNhomMonHoc"/> objects (entity, collection and repository).
    /// </summary>
   public partial class PhanNhomMonHocTest
    {
    	// the PhanNhomMonHoc instance used to test the repository.
		protected PhanNhomMonHoc mock;
		
		// the TList<PhanNhomMonHoc> instance used to test the repository.
		protected TList<PhanNhomMonHoc> mockCollection;
		
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
			System.Console.WriteLine("-- Testing the PhanNhomMonHoc Entity with the {0} --", PMS.Data.DataRepository.Provider.Name);
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
		/// Inserts a mock PhanNhomMonHoc entity into the database.
		/// </summary>
		private void Step_01_Insert_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.PhanNhomMonHocProvider.Insert(tm, mock), "Insert failed");
										
				System.Console.WriteLine("DataRepository.PhanNhomMonHocProvider.Insert(mock):");			
				System.Console.WriteLine(mock);			
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Selects all PhanNhomMonHoc objects of the database.
		/// </summary>
		private void Step_02_SelectAll_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				//Find
				int count = -1;
				
				mockCollection = DataRepository.PhanNhomMonHocProvider.Find(tm, null, "", 0, 10, out count );
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue Find Command.");
				
				System.Console.WriteLine("DataRepository.PhanNhomMonHocProvider.Find():");			
				System.Console.WriteLine(mockCollection);
				
				// GetPaged
				count = -1;
				
				mockCollection = DataRepository.PhanNhomMonHocProvider.GetPaged(tm, 0, 10, out count);
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue GetPaged Command.");
				System.Console.WriteLine("#get paged count: " + count.ToString());
			}
		}
		
		
		
		
		/// <summary>
		/// Deep load all PhanNhomMonHoc children.
		/// </summary>
		private void Step_03_DeepLoad_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				int count = -1;
				mock =  CreateMockInstance(tm);
				mockCollection = DataRepository.PhanNhomMonHocProvider.GetPaged(tm, 0, 10, out count);
			
				DataRepository.PhanNhomMonHocProvider.DeepLoading += new EntityProviderBaseCore<PhanNhomMonHoc, PhanNhomMonHocKey>.DeepLoadingEventHandler(
						delegate(object sender, DeepSessionEventArgs e)
						{
							if (e.DeepSession.Count > 3)
								e.Cancel = true;
						}
					);

				if (mockCollection.Count > 0)
				{
					
					DataRepository.PhanNhomMonHocProvider.DeepLoad(tm, mockCollection[0]);
					System.Console.WriteLine("PhanNhomMonHoc instance correctly deep loaded at 1 level.");
									
					mockCollection.Add(mock);
					// DataRepository.PhanNhomMonHocProvider.DeepSave(tm, mockCollection);
				}
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		/// <summary>
		/// Updates a mock PhanNhomMonHoc entity into the database.
		/// </summary>
		private void Step_04_Update_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				PhanNhomMonHoc mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.PhanNhomMonHocProvider.Insert(tm, mock), "Insert failed");
				
				UpdateMockInstance(tm, mock);
				Assert.IsTrue(DataRepository.PhanNhomMonHocProvider.Update(tm, mock), "Update failed.");			
				
				System.Console.WriteLine("DataRepository.PhanNhomMonHocProvider.Update(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Delete the mock PhanNhomMonHoc entity into the database.
		/// </summary>
		private void Step_05_Delete_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  (PhanNhomMonHoc)CreateMockInstance(tm);
				DataRepository.PhanNhomMonHocProvider.Insert(tm, mock);
			
				Assert.IsTrue(DataRepository.PhanNhomMonHocProvider.Delete(tm, mock), "Delete failed.");
				System.Console.WriteLine("DataRepository.PhanNhomMonHocProvider.Delete(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		#region Serialization tests
		
		/// <summary>
		/// Serialize the mock PhanNhomMonHoc entity into a temporary file.
		/// </summary>
		private void Step_06_SerializeEntity_Generated()
		{	
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  CreateMockInstance(tm);
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_PhanNhomMonHoc.xml");
			
				EntityHelper.SerializeXml(mock, fileName);
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock not found");
					
				System.Console.WriteLine("mock correctly serialized to a temporary file.");			
			}
		}
		
		/// <summary>
		/// Deserialize the mock PhanNhomMonHoc entity from a temporary file.
		/// </summary>
		private void Step_07_DeserializeEntity_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_PhanNhomMonHoc.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			using (System.IO.StreamReader sr = System.IO.File.OpenText(fileName))
			{
				object item = EntityHelper.DeserializeEntityXml<PhanNhomMonHoc>(sr.ReadToEnd());
				sr.Close();
			}
			System.IO.File.Delete(fileName);
			
			System.Console.WriteLine("mock correctly deserialized from a temporary file.");
		}
		
		/// <summary>
		/// Serialize a PhanNhomMonHoc collection into a temporary file.
		/// </summary>
		private void Step_08_SerializeCollection_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_PhanNhomMonHocCollection.xml");
				
				mock = CreateMockInstance(tm);
				TList<PhanNhomMonHoc> mockCollection = new TList<PhanNhomMonHoc>();
				mockCollection.Add(mock);
			
				EntityHelper.SerializeXml(mockCollection, fileName);
				
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock collection not found");
				System.Console.WriteLine("TList<PhanNhomMonHoc> correctly serialized to a temporary file.");					
			}
		}
		
		
		/// <summary>
		/// Deserialize a PhanNhomMonHoc collection from a temporary file.
		/// </summary>
		private void Step_09_DeserializeCollection_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_PhanNhomMonHocCollection.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			XmlSerializer mySerializer = new XmlSerializer(typeof(TList<PhanNhomMonHoc>)); 
			using (System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open))
			{
				TList<PhanNhomMonHoc> mockCollection = (TList<PhanNhomMonHoc>) mySerializer.Deserialize(myFileStream);
				myFileStream.Close();
			}
			
			System.IO.File.Delete(fileName);
			System.Console.WriteLine("TList<PhanNhomMonHoc> correctly deserialized from a temporary file.");	
		}
		#endregion
		
		
		
		/// <summary>
		/// Check the foreign key dal methods.
		/// </summary>
		private void Step_10_FK_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				PhanNhomMonHoc entity = CreateMockInstance(tm);
				bool result = DataRepository.PhanNhomMonHocProvider.Insert(tm, entity);
				
				Assert.IsTrue(result, "Could Not Test FK, Insert Failed");
				
				TList<PhanNhomMonHoc> t0 = DataRepository.PhanNhomMonHocProvider.GetByMaNhomMonHoc(tm, entity.MaNhomMonHoc, 0, 10);
			}
		}
		
		
		/// <summary>
		/// Check the indexes dal methods.
		/// </summary>
		private void Step_11_IX_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				PhanNhomMonHoc entity = CreateMockInstance(tm);
				bool result = DataRepository.PhanNhomMonHocProvider.Insert(tm, entity);
				
				Assert.IsTrue(result, "Could Not Test IX, Insert Failed");

			
				PhanNhomMonHoc t0 = DataRepository.PhanNhomMonHocProvider.GetById(tm, entity.Id);
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
				
				PhanNhomMonHoc entity = mock.Copy() as PhanNhomMonHoc;
				entity = (PhanNhomMonHoc)mock.Clone();
				Assert.IsTrue(PhanNhomMonHoc.ValueEquals(entity, mock), "Clone is not working");
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
				PhanNhomMonHoc mock = CreateMockInstance(tm);
				bool result = DataRepository.PhanNhomMonHocProvider.Insert(tm, mock);
				
				Assert.IsTrue(result, "Could Not Test FindByQuery, Insert Failed");

				PhanNhomMonHocQuery query = new PhanNhomMonHocQuery();
			
				query.AppendEquals(PhanNhomMonHocColumn.Id, mock.Id.ToString());
				query.AppendEquals(PhanNhomMonHocColumn.MaMonHoc, mock.MaMonHoc.ToString());
				if(mock.MaLoaiHocPhan != null)
					query.AppendEquals(PhanNhomMonHocColumn.MaLoaiHocPhan, mock.MaLoaiHocPhan.ToString());
				query.AppendEquals(PhanNhomMonHocColumn.MaNhomMonHoc, mock.MaNhomMonHoc.ToString());
				if(mock.NamHoc != null)
					query.AppendEquals(PhanNhomMonHocColumn.NamHoc, mock.NamHoc.ToString());
				if(mock.HocKy != null)
					query.AppendEquals(PhanNhomMonHocColumn.HocKy, mock.HocKy.ToString());
				
				TList<PhanNhomMonHoc> results = DataRepository.PhanNhomMonHocProvider.Find(tm, query);
				
				Assert.IsTrue(results.Count == 1, "Find is not working correctly.  Failed to find the mock instance");
			}
		}
						
		#region Mock Instance
		///<summary>
		///  Returns a Typed PhanNhomMonHoc Entity with mock values.
		///</summary>
		static public PhanNhomMonHoc CreateMockInstance_Generated(TransactionManager tm)
		{		
			PhanNhomMonHoc mock = new PhanNhomMonHoc();
						
			mock.MaMonHoc = TestUtility.Instance.RandomString(9, false);;
			mock.MaLoaiHocPhan = TestUtility.Instance.RandomNumber();
			mock.NamHoc = TestUtility.Instance.RandomString(9, false);;
			mock.HocKy = TestUtility.Instance.RandomString(9, false);;
			
			//OneToOneRelationship
			NhomMonHoc mockNhomMonHocByMaNhomMonHoc = NhomMonHocTest.CreateMockInstance(tm);
			DataRepository.NhomMonHocProvider.Insert(tm, mockNhomMonHocByMaNhomMonHoc);
			mock.MaNhomMonHoc = mockNhomMonHocByMaNhomMonHoc.MaNhomMon;
		
			// create a temporary collection and add the item to it
			TList<PhanNhomMonHoc> tempMockCollection = new TList<PhanNhomMonHoc>();
			tempMockCollection.Add(mock);
			tempMockCollection.Remove(mock);
			
		
		   return (PhanNhomMonHoc)mock;
		}
		
		
		///<summary>
		///  Update the Typed PhanNhomMonHoc Entity with modified mock values.
		///</summary>
		static public void UpdateMockInstance_Generated(TransactionManager tm, PhanNhomMonHoc mock)
		{
			mock.MaMonHoc = TestUtility.Instance.RandomString(9, false);;
			mock.MaLoaiHocPhan = TestUtility.Instance.RandomNumber();
			mock.NamHoc = TestUtility.Instance.RandomString(9, false);;
			mock.HocKy = TestUtility.Instance.RandomString(9, false);;
			
			//OneToOneRelationship
			NhomMonHoc mockNhomMonHocByMaNhomMonHoc = NhomMonHocTest.CreateMockInstance(tm);
			DataRepository.NhomMonHocProvider.Insert(tm, mockNhomMonHocByMaNhomMonHoc);
			mock.MaNhomMonHoc = mockNhomMonHocByMaNhomMonHoc.MaNhomMon;
					
		}
		#endregion
    }
}
