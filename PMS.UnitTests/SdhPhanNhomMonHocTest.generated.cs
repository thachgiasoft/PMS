﻿
/*
	File Generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file SdhPhanNhomMonHocTest.cs instead.
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
    /// Provides tests for the and <see cref="SdhPhanNhomMonHoc"/> objects (entity, collection and repository).
    /// </summary>
   public partial class SdhPhanNhomMonHocTest
    {
    	// the SdhPhanNhomMonHoc instance used to test the repository.
		protected SdhPhanNhomMonHoc mock;
		
		// the TList<SdhPhanNhomMonHoc> instance used to test the repository.
		protected TList<SdhPhanNhomMonHoc> mockCollection;
		
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
			System.Console.WriteLine("-- Testing the SdhPhanNhomMonHoc Entity with the {0} --", PMS.Data.DataRepository.Provider.Name);
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
		/// Inserts a mock SdhPhanNhomMonHoc entity into the database.
		/// </summary>
		private void Step_01_Insert_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.SdhPhanNhomMonHocProvider.Insert(tm, mock), "Insert failed");
										
				System.Console.WriteLine("DataRepository.SdhPhanNhomMonHocProvider.Insert(mock):");			
				System.Console.WriteLine(mock);			
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Selects all SdhPhanNhomMonHoc objects of the database.
		/// </summary>
		private void Step_02_SelectAll_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				//Find
				int count = -1;
				
				mockCollection = DataRepository.SdhPhanNhomMonHocProvider.Find(tm, null, "", 0, 10, out count );
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue Find Command.");
				
				System.Console.WriteLine("DataRepository.SdhPhanNhomMonHocProvider.Find():");			
				System.Console.WriteLine(mockCollection);
				
				// GetPaged
				count = -1;
				
				mockCollection = DataRepository.SdhPhanNhomMonHocProvider.GetPaged(tm, 0, 10, out count);
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue GetPaged Command.");
				System.Console.WriteLine("#get paged count: " + count.ToString());
			}
		}
		
		
		
		
		/// <summary>
		/// Deep load all SdhPhanNhomMonHoc children.
		/// </summary>
		private void Step_03_DeepLoad_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				int count = -1;
				mock =  CreateMockInstance(tm);
				mockCollection = DataRepository.SdhPhanNhomMonHocProvider.GetPaged(tm, 0, 10, out count);
			
				DataRepository.SdhPhanNhomMonHocProvider.DeepLoading += new EntityProviderBaseCore<SdhPhanNhomMonHoc, SdhPhanNhomMonHocKey>.DeepLoadingEventHandler(
						delegate(object sender, DeepSessionEventArgs e)
						{
							if (e.DeepSession.Count > 3)
								e.Cancel = true;
						}
					);

				if (mockCollection.Count > 0)
				{
					
					DataRepository.SdhPhanNhomMonHocProvider.DeepLoad(tm, mockCollection[0]);
					System.Console.WriteLine("SdhPhanNhomMonHoc instance correctly deep loaded at 1 level.");
									
					mockCollection.Add(mock);
					// DataRepository.SdhPhanNhomMonHocProvider.DeepSave(tm, mockCollection);
				}
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		/// <summary>
		/// Updates a mock SdhPhanNhomMonHoc entity into the database.
		/// </summary>
		private void Step_04_Update_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				SdhPhanNhomMonHoc mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.SdhPhanNhomMonHocProvider.Insert(tm, mock), "Insert failed");
				
				UpdateMockInstance(tm, mock);
				Assert.IsTrue(DataRepository.SdhPhanNhomMonHocProvider.Update(tm, mock), "Update failed.");			
				
				System.Console.WriteLine("DataRepository.SdhPhanNhomMonHocProvider.Update(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Delete the mock SdhPhanNhomMonHoc entity into the database.
		/// </summary>
		private void Step_05_Delete_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  (SdhPhanNhomMonHoc)CreateMockInstance(tm);
				DataRepository.SdhPhanNhomMonHocProvider.Insert(tm, mock);
			
				Assert.IsTrue(DataRepository.SdhPhanNhomMonHocProvider.Delete(tm, mock), "Delete failed.");
				System.Console.WriteLine("DataRepository.SdhPhanNhomMonHocProvider.Delete(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		#region Serialization tests
		
		/// <summary>
		/// Serialize the mock SdhPhanNhomMonHoc entity into a temporary file.
		/// </summary>
		private void Step_06_SerializeEntity_Generated()
		{	
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  CreateMockInstance(tm);
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_SdhPhanNhomMonHoc.xml");
			
				EntityHelper.SerializeXml(mock, fileName);
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock not found");
					
				System.Console.WriteLine("mock correctly serialized to a temporary file.");			
			}
		}
		
		/// <summary>
		/// Deserialize the mock SdhPhanNhomMonHoc entity from a temporary file.
		/// </summary>
		private void Step_07_DeserializeEntity_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_SdhPhanNhomMonHoc.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			using (System.IO.StreamReader sr = System.IO.File.OpenText(fileName))
			{
				object item = EntityHelper.DeserializeEntityXml<SdhPhanNhomMonHoc>(sr.ReadToEnd());
				sr.Close();
			}
			System.IO.File.Delete(fileName);
			
			System.Console.WriteLine("mock correctly deserialized from a temporary file.");
		}
		
		/// <summary>
		/// Serialize a SdhPhanNhomMonHoc collection into a temporary file.
		/// </summary>
		private void Step_08_SerializeCollection_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_SdhPhanNhomMonHocCollection.xml");
				
				mock = CreateMockInstance(tm);
				TList<SdhPhanNhomMonHoc> mockCollection = new TList<SdhPhanNhomMonHoc>();
				mockCollection.Add(mock);
			
				EntityHelper.SerializeXml(mockCollection, fileName);
				
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock collection not found");
				System.Console.WriteLine("TList<SdhPhanNhomMonHoc> correctly serialized to a temporary file.");					
			}
		}
		
		
		/// <summary>
		/// Deserialize a SdhPhanNhomMonHoc collection from a temporary file.
		/// </summary>
		private void Step_09_DeserializeCollection_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_SdhPhanNhomMonHocCollection.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			XmlSerializer mySerializer = new XmlSerializer(typeof(TList<SdhPhanNhomMonHoc>)); 
			using (System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open))
			{
				TList<SdhPhanNhomMonHoc> mockCollection = (TList<SdhPhanNhomMonHoc>) mySerializer.Deserialize(myFileStream);
				myFileStream.Close();
			}
			
			System.IO.File.Delete(fileName);
			System.Console.WriteLine("TList<SdhPhanNhomMonHoc> correctly deserialized from a temporary file.");	
		}
		#endregion
		
		
		
		/// <summary>
		/// Check the foreign key dal methods.
		/// </summary>
		private void Step_10_FK_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				SdhPhanNhomMonHoc entity = CreateMockInstance(tm);
				bool result = DataRepository.SdhPhanNhomMonHocProvider.Insert(tm, entity);
				
				Assert.IsTrue(result, "Could Not Test FK, Insert Failed");
				
				TList<SdhPhanNhomMonHoc> t0 = DataRepository.SdhPhanNhomMonHocProvider.GetByMaNhomMonHoc(tm, entity.MaNhomMonHoc, 0, 10);
			}
		}
		
		
		/// <summary>
		/// Check the indexes dal methods.
		/// </summary>
		private void Step_11_IX_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				SdhPhanNhomMonHoc entity = CreateMockInstance(tm);
				bool result = DataRepository.SdhPhanNhomMonHocProvider.Insert(tm, entity);
				
				Assert.IsTrue(result, "Could Not Test IX, Insert Failed");

			
				SdhPhanNhomMonHoc t0 = DataRepository.SdhPhanNhomMonHocProvider.GetById(tm, entity.Id);
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
				
				SdhPhanNhomMonHoc entity = mock.Copy() as SdhPhanNhomMonHoc;
				entity = (SdhPhanNhomMonHoc)mock.Clone();
				Assert.IsTrue(SdhPhanNhomMonHoc.ValueEquals(entity, mock), "Clone is not working");
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
				SdhPhanNhomMonHoc mock = CreateMockInstance(tm);
				bool result = DataRepository.SdhPhanNhomMonHocProvider.Insert(tm, mock);
				
				Assert.IsTrue(result, "Could Not Test FindByQuery, Insert Failed");

				SdhPhanNhomMonHocQuery query = new SdhPhanNhomMonHocQuery();
			
				query.AppendEquals(SdhPhanNhomMonHocColumn.Id, mock.Id.ToString());
				query.AppendEquals(SdhPhanNhomMonHocColumn.MaMonHoc, mock.MaMonHoc.ToString());
				if(mock.MaLoaiHocPhan != null)
					query.AppendEquals(SdhPhanNhomMonHocColumn.MaLoaiHocPhan, mock.MaLoaiHocPhan.ToString());
				query.AppendEquals(SdhPhanNhomMonHocColumn.MaNhomMonHoc, mock.MaNhomMonHoc.ToString());
				if(mock.NamHoc != null)
					query.AppendEquals(SdhPhanNhomMonHocColumn.NamHoc, mock.NamHoc.ToString());
				if(mock.HocKy != null)
					query.AppendEquals(SdhPhanNhomMonHocColumn.HocKy, mock.HocKy.ToString());
				
				TList<SdhPhanNhomMonHoc> results = DataRepository.SdhPhanNhomMonHocProvider.Find(tm, query);
				
				Assert.IsTrue(results.Count == 1, "Find is not working correctly.  Failed to find the mock instance");
			}
		}
						
		#region Mock Instance
		///<summary>
		///  Returns a Typed SdhPhanNhomMonHoc Entity with mock values.
		///</summary>
		static public SdhPhanNhomMonHoc CreateMockInstance_Generated(TransactionManager tm)
		{		
			SdhPhanNhomMonHoc mock = new SdhPhanNhomMonHoc();
						
			mock.MaMonHoc = TestUtility.Instance.RandomString(9, false);;
			mock.MaLoaiHocPhan = TestUtility.Instance.RandomNumber();
			mock.NamHoc = TestUtility.Instance.RandomString(9, false);;
			mock.HocKy = TestUtility.Instance.RandomString(9, false);;
			
			//OneToOneRelationship
			NhomMonHoc mockNhomMonHocByMaNhomMonHoc = NhomMonHocTest.CreateMockInstance(tm);
			DataRepository.NhomMonHocProvider.Insert(tm, mockNhomMonHocByMaNhomMonHoc);
			mock.MaNhomMonHoc = mockNhomMonHocByMaNhomMonHoc.MaNhomMon;
		
			// create a temporary collection and add the item to it
			TList<SdhPhanNhomMonHoc> tempMockCollection = new TList<SdhPhanNhomMonHoc>();
			tempMockCollection.Add(mock);
			tempMockCollection.Remove(mock);
			
		
		   return (SdhPhanNhomMonHoc)mock;
		}
		
		
		///<summary>
		///  Update the Typed SdhPhanNhomMonHoc Entity with modified mock values.
		///</summary>
		static public void UpdateMockInstance_Generated(TransactionManager tm, SdhPhanNhomMonHoc mock)
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
