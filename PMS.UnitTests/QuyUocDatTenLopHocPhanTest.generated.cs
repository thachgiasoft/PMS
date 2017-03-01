﻿
/*
	File Generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file QuyUocDatTenLopHocPhanTest.cs instead.
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
    /// Provides tests for the and <see cref="QuyUocDatTenLopHocPhan"/> objects (entity, collection and repository).
    /// </summary>
   public partial class QuyUocDatTenLopHocPhanTest
    {
    	// the QuyUocDatTenLopHocPhan instance used to test the repository.
		protected QuyUocDatTenLopHocPhan mock;
		
		// the TList<QuyUocDatTenLopHocPhan> instance used to test the repository.
		protected TList<QuyUocDatTenLopHocPhan> mockCollection;
		
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
			System.Console.WriteLine("-- Testing the QuyUocDatTenLopHocPhan Entity with the {0} --", PMS.Data.DataRepository.Provider.Name);
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
		/// Inserts a mock QuyUocDatTenLopHocPhan entity into the database.
		/// </summary>
		private void Step_01_Insert_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.QuyUocDatTenLopHocPhanProvider.Insert(tm, mock), "Insert failed");
										
				System.Console.WriteLine("DataRepository.QuyUocDatTenLopHocPhanProvider.Insert(mock):");			
				System.Console.WriteLine(mock);			
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Selects all QuyUocDatTenLopHocPhan objects of the database.
		/// </summary>
		private void Step_02_SelectAll_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				//Find
				int count = -1;
				
				mockCollection = DataRepository.QuyUocDatTenLopHocPhanProvider.Find(tm, null, "", 0, 10, out count );
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue Find Command.");
				
				System.Console.WriteLine("DataRepository.QuyUocDatTenLopHocPhanProvider.Find():");			
				System.Console.WriteLine(mockCollection);
				
				// GetPaged
				count = -1;
				
				mockCollection = DataRepository.QuyUocDatTenLopHocPhanProvider.GetPaged(tm, 0, 10, out count);
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue GetPaged Command.");
				System.Console.WriteLine("#get paged count: " + count.ToString());
			}
		}
		
		
		
		
		/// <summary>
		/// Deep load all QuyUocDatTenLopHocPhan children.
		/// </summary>
		private void Step_03_DeepLoad_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				int count = -1;
				mock =  CreateMockInstance(tm);
				mockCollection = DataRepository.QuyUocDatTenLopHocPhanProvider.GetPaged(tm, 0, 10, out count);
			
				DataRepository.QuyUocDatTenLopHocPhanProvider.DeepLoading += new EntityProviderBaseCore<QuyUocDatTenLopHocPhan, QuyUocDatTenLopHocPhanKey>.DeepLoadingEventHandler(
						delegate(object sender, DeepSessionEventArgs e)
						{
							if (e.DeepSession.Count > 3)
								e.Cancel = true;
						}
					);

				if (mockCollection.Count > 0)
				{
					
					DataRepository.QuyUocDatTenLopHocPhanProvider.DeepLoad(tm, mockCollection[0]);
					System.Console.WriteLine("QuyUocDatTenLopHocPhan instance correctly deep loaded at 1 level.");
									
					mockCollection.Add(mock);
					// DataRepository.QuyUocDatTenLopHocPhanProvider.DeepSave(tm, mockCollection);
				}
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		/// <summary>
		/// Updates a mock QuyUocDatTenLopHocPhan entity into the database.
		/// </summary>
		private void Step_04_Update_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				QuyUocDatTenLopHocPhan mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.QuyUocDatTenLopHocPhanProvider.Insert(tm, mock), "Insert failed");
				
				UpdateMockInstance(tm, mock);
				Assert.IsTrue(DataRepository.QuyUocDatTenLopHocPhanProvider.Update(tm, mock), "Update failed.");			
				
				System.Console.WriteLine("DataRepository.QuyUocDatTenLopHocPhanProvider.Update(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Delete the mock QuyUocDatTenLopHocPhan entity into the database.
		/// </summary>
		private void Step_05_Delete_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  (QuyUocDatTenLopHocPhan)CreateMockInstance(tm);
				DataRepository.QuyUocDatTenLopHocPhanProvider.Insert(tm, mock);
			
				Assert.IsTrue(DataRepository.QuyUocDatTenLopHocPhanProvider.Delete(tm, mock), "Delete failed.");
				System.Console.WriteLine("DataRepository.QuyUocDatTenLopHocPhanProvider.Delete(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		#region Serialization tests
		
		/// <summary>
		/// Serialize the mock QuyUocDatTenLopHocPhan entity into a temporary file.
		/// </summary>
		private void Step_06_SerializeEntity_Generated()
		{	
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  CreateMockInstance(tm);
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_QuyUocDatTenLopHocPhan.xml");
			
				EntityHelper.SerializeXml(mock, fileName);
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock not found");
					
				System.Console.WriteLine("mock correctly serialized to a temporary file.");			
			}
		}
		
		/// <summary>
		/// Deserialize the mock QuyUocDatTenLopHocPhan entity from a temporary file.
		/// </summary>
		private void Step_07_DeserializeEntity_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_QuyUocDatTenLopHocPhan.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			using (System.IO.StreamReader sr = System.IO.File.OpenText(fileName))
			{
				object item = EntityHelper.DeserializeEntityXml<QuyUocDatTenLopHocPhan>(sr.ReadToEnd());
				sr.Close();
			}
			System.IO.File.Delete(fileName);
			
			System.Console.WriteLine("mock correctly deserialized from a temporary file.");
		}
		
		/// <summary>
		/// Serialize a QuyUocDatTenLopHocPhan collection into a temporary file.
		/// </summary>
		private void Step_08_SerializeCollection_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_QuyUocDatTenLopHocPhanCollection.xml");
				
				mock = CreateMockInstance(tm);
				TList<QuyUocDatTenLopHocPhan> mockCollection = new TList<QuyUocDatTenLopHocPhan>();
				mockCollection.Add(mock);
			
				EntityHelper.SerializeXml(mockCollection, fileName);
				
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock collection not found");
				System.Console.WriteLine("TList<QuyUocDatTenLopHocPhan> correctly serialized to a temporary file.");					
			}
		}
		
		
		/// <summary>
		/// Deserialize a QuyUocDatTenLopHocPhan collection from a temporary file.
		/// </summary>
		private void Step_09_DeserializeCollection_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_QuyUocDatTenLopHocPhanCollection.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			XmlSerializer mySerializer = new XmlSerializer(typeof(TList<QuyUocDatTenLopHocPhan>)); 
			using (System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open))
			{
				TList<QuyUocDatTenLopHocPhan> mockCollection = (TList<QuyUocDatTenLopHocPhan>) mySerializer.Deserialize(myFileStream);
				myFileStream.Close();
			}
			
			System.IO.File.Delete(fileName);
			System.Console.WriteLine("TList<QuyUocDatTenLopHocPhan> correctly deserialized from a temporary file.");	
		}
		#endregion
		
		
		
		/// <summary>
		/// Check the foreign key dal methods.
		/// </summary>
		private void Step_10_FK_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				QuyUocDatTenLopHocPhan entity = CreateMockInstance(tm);
				bool result = DataRepository.QuyUocDatTenLopHocPhanProvider.Insert(tm, entity);
				
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
				QuyUocDatTenLopHocPhan entity = CreateMockInstance(tm);
				bool result = DataRepository.QuyUocDatTenLopHocPhanProvider.Insert(tm, entity);
				
				Assert.IsTrue(result, "Could Not Test IX, Insert Failed");

			
				QuyUocDatTenLopHocPhan t0 = DataRepository.QuyUocDatTenLopHocPhanProvider.GetById(tm, entity.Id);
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
				
				QuyUocDatTenLopHocPhan entity = mock.Copy() as QuyUocDatTenLopHocPhan;
				entity = (QuyUocDatTenLopHocPhan)mock.Clone();
				Assert.IsTrue(QuyUocDatTenLopHocPhan.ValueEquals(entity, mock), "Clone is not working");
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
				QuyUocDatTenLopHocPhan mock = CreateMockInstance(tm);
				bool result = DataRepository.QuyUocDatTenLopHocPhanProvider.Insert(tm, mock);
				
				Assert.IsTrue(result, "Could Not Test FindByQuery, Insert Failed");

				QuyUocDatTenLopHocPhanQuery query = new QuyUocDatTenLopHocPhanQuery();
			
				query.AppendEquals(QuyUocDatTenLopHocPhanColumn.Id, mock.Id.ToString());
				if(mock.MaHinhThucDaoTao != null)
					query.AppendEquals(QuyUocDatTenLopHocPhanColumn.MaHinhThucDaoTao, mock.MaHinhThucDaoTao.ToString());
				if(mock.NamHoc != null)
					query.AppendEquals(QuyUocDatTenLopHocPhanColumn.NamHoc, mock.NamHoc.ToString());
				if(mock.HocKy != null)
					query.AppendEquals(QuyUocDatTenLopHocPhanColumn.HocKy, mock.HocKy.ToString());
				if(mock.TuMaLop != null)
					query.AppendEquals(QuyUocDatTenLopHocPhanColumn.TuMaLop, mock.TuMaLop.ToString());
				if(mock.DenMaLop != null)
					query.AppendEquals(QuyUocDatTenLopHocPhanColumn.DenMaLop, mock.DenMaLop.ToString());
				if(mock.GhiChu != null)
					query.AppendEquals(QuyUocDatTenLopHocPhanColumn.GhiChu, mock.GhiChu.ToString());
				
				TList<QuyUocDatTenLopHocPhan> results = DataRepository.QuyUocDatTenLopHocPhanProvider.Find(tm, query);
				
				Assert.IsTrue(results.Count == 1, "Find is not working correctly.  Failed to find the mock instance");
			}
		}
						
		#region Mock Instance
		///<summary>
		///  Returns a Typed QuyUocDatTenLopHocPhan Entity with mock values.
		///</summary>
		static public QuyUocDatTenLopHocPhan CreateMockInstance_Generated(TransactionManager tm)
		{		
			QuyUocDatTenLopHocPhan mock = new QuyUocDatTenLopHocPhan();
						
			mock.MaHinhThucDaoTao = TestUtility.Instance.RandomString(9, false);;
			mock.NamHoc = TestUtility.Instance.RandomString(9, false);;
			mock.HocKy = TestUtility.Instance.RandomString(9, false);;
			mock.TuMaLop = TestUtility.Instance.RandomString(9, false);;
			mock.DenMaLop = TestUtility.Instance.RandomString(9, false);;
			mock.GhiChu = TestUtility.Instance.RandomString(249, false);;
			
		
			// create a temporary collection and add the item to it
			TList<QuyUocDatTenLopHocPhan> tempMockCollection = new TList<QuyUocDatTenLopHocPhan>();
			tempMockCollection.Add(mock);
			tempMockCollection.Remove(mock);
			
		
		   return (QuyUocDatTenLopHocPhan)mock;
		}
		
		
		///<summary>
		///  Update the Typed QuyUocDatTenLopHocPhan Entity with modified mock values.
		///</summary>
		static public void UpdateMockInstance_Generated(TransactionManager tm, QuyUocDatTenLopHocPhan mock)
		{
			mock.MaHinhThucDaoTao = TestUtility.Instance.RandomString(9, false);;
			mock.NamHoc = TestUtility.Instance.RandomString(9, false);;
			mock.HocKy = TestUtility.Instance.RandomString(9, false);;
			mock.TuMaLop = TestUtility.Instance.RandomString(9, false);;
			mock.DenMaLop = TestUtility.Instance.RandomString(9, false);;
			mock.GhiChu = TestUtility.Instance.RandomString(249, false);;
			
		}
		#endregion
    }
}
