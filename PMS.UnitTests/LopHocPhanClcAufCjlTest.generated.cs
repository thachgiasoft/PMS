﻿
/*
	File Generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file LopHocPhanClcAufCjlTest.cs instead.
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
    /// Provides tests for the and <see cref="LopHocPhanClcAufCjl"/> objects (entity, collection and repository).
    /// </summary>
   public partial class LopHocPhanClcAufCjlTest
    {
    	// the LopHocPhanClcAufCjl instance used to test the repository.
		protected LopHocPhanClcAufCjl mock;
		
		// the TList<LopHocPhanClcAufCjl> instance used to test the repository.
		protected TList<LopHocPhanClcAufCjl> mockCollection;
		
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
			System.Console.WriteLine("-- Testing the LopHocPhanClcAufCjl Entity with the {0} --", PMS.Data.DataRepository.Provider.Name);
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
		/// Inserts a mock LopHocPhanClcAufCjl entity into the database.
		/// </summary>
		private void Step_01_Insert_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.LopHocPhanClcAufCjlProvider.Insert(tm, mock), "Insert failed");
										
				System.Console.WriteLine("DataRepository.LopHocPhanClcAufCjlProvider.Insert(mock):");			
				System.Console.WriteLine(mock);			
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Selects all LopHocPhanClcAufCjl objects of the database.
		/// </summary>
		private void Step_02_SelectAll_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				//Find
				int count = -1;
				
				mockCollection = DataRepository.LopHocPhanClcAufCjlProvider.Find(tm, null, "", 0, 10, out count );
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue Find Command.");
				
				System.Console.WriteLine("DataRepository.LopHocPhanClcAufCjlProvider.Find():");			
				System.Console.WriteLine(mockCollection);
				
				// GetPaged
				count = -1;
				
				mockCollection = DataRepository.LopHocPhanClcAufCjlProvider.GetPaged(tm, 0, 10, out count);
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue GetPaged Command.");
				System.Console.WriteLine("#get paged count: " + count.ToString());
			}
		}
		
		
		
		
		/// <summary>
		/// Deep load all LopHocPhanClcAufCjl children.
		/// </summary>
		private void Step_03_DeepLoad_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				int count = -1;
				mock =  CreateMockInstance(tm);
				mockCollection = DataRepository.LopHocPhanClcAufCjlProvider.GetPaged(tm, 0, 10, out count);
			
				DataRepository.LopHocPhanClcAufCjlProvider.DeepLoading += new EntityProviderBaseCore<LopHocPhanClcAufCjl, LopHocPhanClcAufCjlKey>.DeepLoadingEventHandler(
						delegate(object sender, DeepSessionEventArgs e)
						{
							if (e.DeepSession.Count > 3)
								e.Cancel = true;
						}
					);

				if (mockCollection.Count > 0)
				{
					
					DataRepository.LopHocPhanClcAufCjlProvider.DeepLoad(tm, mockCollection[0]);
					System.Console.WriteLine("LopHocPhanClcAufCjl instance correctly deep loaded at 1 level.");
									
					mockCollection.Add(mock);
					// DataRepository.LopHocPhanClcAufCjlProvider.DeepSave(tm, mockCollection);
				}
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		/// <summary>
		/// Updates a mock LopHocPhanClcAufCjl entity into the database.
		/// </summary>
		private void Step_04_Update_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				LopHocPhanClcAufCjl mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.LopHocPhanClcAufCjlProvider.Insert(tm, mock), "Insert failed");
				
				UpdateMockInstance(tm, mock);
				Assert.IsTrue(DataRepository.LopHocPhanClcAufCjlProvider.Update(tm, mock), "Update failed.");			
				
				System.Console.WriteLine("DataRepository.LopHocPhanClcAufCjlProvider.Update(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Delete the mock LopHocPhanClcAufCjl entity into the database.
		/// </summary>
		private void Step_05_Delete_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  (LopHocPhanClcAufCjl)CreateMockInstance(tm);
				DataRepository.LopHocPhanClcAufCjlProvider.Insert(tm, mock);
			
				Assert.IsTrue(DataRepository.LopHocPhanClcAufCjlProvider.Delete(tm, mock), "Delete failed.");
				System.Console.WriteLine("DataRepository.LopHocPhanClcAufCjlProvider.Delete(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		#region Serialization tests
		
		/// <summary>
		/// Serialize the mock LopHocPhanClcAufCjl entity into a temporary file.
		/// </summary>
		private void Step_06_SerializeEntity_Generated()
		{	
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  CreateMockInstance(tm);
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_LopHocPhanClcAufCjl.xml");
			
				EntityHelper.SerializeXml(mock, fileName);
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock not found");
					
				System.Console.WriteLine("mock correctly serialized to a temporary file.");			
			}
		}
		
		/// <summary>
		/// Deserialize the mock LopHocPhanClcAufCjl entity from a temporary file.
		/// </summary>
		private void Step_07_DeserializeEntity_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_LopHocPhanClcAufCjl.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			using (System.IO.StreamReader sr = System.IO.File.OpenText(fileName))
			{
				object item = EntityHelper.DeserializeEntityXml<LopHocPhanClcAufCjl>(sr.ReadToEnd());
				sr.Close();
			}
			System.IO.File.Delete(fileName);
			
			System.Console.WriteLine("mock correctly deserialized from a temporary file.");
		}
		
		/// <summary>
		/// Serialize a LopHocPhanClcAufCjl collection into a temporary file.
		/// </summary>
		private void Step_08_SerializeCollection_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_LopHocPhanClcAufCjlCollection.xml");
				
				mock = CreateMockInstance(tm);
				TList<LopHocPhanClcAufCjl> mockCollection = new TList<LopHocPhanClcAufCjl>();
				mockCollection.Add(mock);
			
				EntityHelper.SerializeXml(mockCollection, fileName);
				
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock collection not found");
				System.Console.WriteLine("TList<LopHocPhanClcAufCjl> correctly serialized to a temporary file.");					
			}
		}
		
		
		/// <summary>
		/// Deserialize a LopHocPhanClcAufCjl collection from a temporary file.
		/// </summary>
		private void Step_09_DeserializeCollection_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_LopHocPhanClcAufCjlCollection.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			XmlSerializer mySerializer = new XmlSerializer(typeof(TList<LopHocPhanClcAufCjl>)); 
			using (System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open))
			{
				TList<LopHocPhanClcAufCjl> mockCollection = (TList<LopHocPhanClcAufCjl>) mySerializer.Deserialize(myFileStream);
				myFileStream.Close();
			}
			
			System.IO.File.Delete(fileName);
			System.Console.WriteLine("TList<LopHocPhanClcAufCjl> correctly deserialized from a temporary file.");	
		}
		#endregion
		
		
		
		/// <summary>
		/// Check the foreign key dal methods.
		/// </summary>
		private void Step_10_FK_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				LopHocPhanClcAufCjl entity = CreateMockInstance(tm);
				bool result = DataRepository.LopHocPhanClcAufCjlProvider.Insert(tm, entity);
				
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
				LopHocPhanClcAufCjl entity = CreateMockInstance(tm);
				bool result = DataRepository.LopHocPhanClcAufCjlProvider.Insert(tm, entity);
				
				Assert.IsTrue(result, "Could Not Test IX, Insert Failed");

			
				LopHocPhanClcAufCjl t0 = DataRepository.LopHocPhanClcAufCjlProvider.GetByMaLopHocPhan(tm, entity.MaLopHocPhan);
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
				
				LopHocPhanClcAufCjl entity = mock.Copy() as LopHocPhanClcAufCjl;
				entity = (LopHocPhanClcAufCjl)mock.Clone();
				Assert.IsTrue(LopHocPhanClcAufCjl.ValueEquals(entity, mock), "Clone is not working");
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
				LopHocPhanClcAufCjl mock = CreateMockInstance(tm);
				bool result = DataRepository.LopHocPhanClcAufCjlProvider.Insert(tm, mock);
				
				Assert.IsTrue(result, "Could Not Test FindByQuery, Insert Failed");

				LopHocPhanClcAufCjlQuery query = new LopHocPhanClcAufCjlQuery();
			
				query.AppendEquals(LopHocPhanClcAufCjlColumn.MaLopHocPhan, mock.MaLopHocPhan.ToString());
				if(mock.Chon != null)
					query.AppendEquals(LopHocPhanClcAufCjlColumn.Chon, mock.Chon.ToString());
				if(mock.NamHoc != null)
					query.AppendEquals(LopHocPhanClcAufCjlColumn.NamHoc, mock.NamHoc.ToString());
				if(mock.HocKy != null)
					query.AppendEquals(LopHocPhanClcAufCjlColumn.HocKy, mock.HocKy.ToString());
				
				TList<LopHocPhanClcAufCjl> results = DataRepository.LopHocPhanClcAufCjlProvider.Find(tm, query);
				
				Assert.IsTrue(results.Count == 1, "Find is not working correctly.  Failed to find the mock instance");
			}
		}
						
		#region Mock Instance
		///<summary>
		///  Returns a Typed LopHocPhanClcAufCjl Entity with mock values.
		///</summary>
		static public LopHocPhanClcAufCjl CreateMockInstance_Generated(TransactionManager tm)
		{		
			LopHocPhanClcAufCjl mock = new LopHocPhanClcAufCjl();
						
			mock.MaLopHocPhan = TestUtility.Instance.RandomString(9, false);;
			mock.Chon = TestUtility.Instance.RandomBoolean();
			mock.NamHoc = TestUtility.Instance.RandomString(9, false);;
			mock.HocKy = TestUtility.Instance.RandomString(9, false);;
			
		
			// create a temporary collection and add the item to it
			TList<LopHocPhanClcAufCjl> tempMockCollection = new TList<LopHocPhanClcAufCjl>();
			tempMockCollection.Add(mock);
			tempMockCollection.Remove(mock);
			
		
		   return (LopHocPhanClcAufCjl)mock;
		}
		
		
		///<summary>
		///  Update the Typed LopHocPhanClcAufCjl Entity with modified mock values.
		///</summary>
		static public void UpdateMockInstance_Generated(TransactionManager tm, LopHocPhanClcAufCjl mock)
		{
			mock.Chon = TestUtility.Instance.RandomBoolean();
			mock.NamHoc = TestUtility.Instance.RandomString(9, false);;
			mock.HocKy = TestUtility.Instance.RandomString(9, false);;
			
		}
		#endregion
    }
}
