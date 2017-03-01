﻿
/*
	File Generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file KetQuaCacKhoanChiKhacTest.cs instead.
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
    /// Provides tests for the and <see cref="KetQuaCacKhoanChiKhac"/> objects (entity, collection and repository).
    /// </summary>
   public partial class KetQuaCacKhoanChiKhacTest
    {
    	// the KetQuaCacKhoanChiKhac instance used to test the repository.
		protected KetQuaCacKhoanChiKhac mock;
		
		// the TList<KetQuaCacKhoanChiKhac> instance used to test the repository.
		protected TList<KetQuaCacKhoanChiKhac> mockCollection;
		
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
			System.Console.WriteLine("-- Testing the KetQuaCacKhoanChiKhac Entity with the {0} --", PMS.Data.DataRepository.Provider.Name);
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
		/// Inserts a mock KetQuaCacKhoanChiKhac entity into the database.
		/// </summary>
		private void Step_01_Insert_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.KetQuaCacKhoanChiKhacProvider.Insert(tm, mock), "Insert failed");
										
				System.Console.WriteLine("DataRepository.KetQuaCacKhoanChiKhacProvider.Insert(mock):");			
				System.Console.WriteLine(mock);			
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Selects all KetQuaCacKhoanChiKhac objects of the database.
		/// </summary>
		private void Step_02_SelectAll_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				//Find
				int count = -1;
				
				mockCollection = DataRepository.KetQuaCacKhoanChiKhacProvider.Find(tm, null, "", 0, 10, out count );
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue Find Command.");
				
				System.Console.WriteLine("DataRepository.KetQuaCacKhoanChiKhacProvider.Find():");			
				System.Console.WriteLine(mockCollection);
				
				// GetPaged
				count = -1;
				
				mockCollection = DataRepository.KetQuaCacKhoanChiKhacProvider.GetPaged(tm, 0, 10, out count);
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue GetPaged Command.");
				System.Console.WriteLine("#get paged count: " + count.ToString());
			}
		}
		
		
		
		
		/// <summary>
		/// Deep load all KetQuaCacKhoanChiKhac children.
		/// </summary>
		private void Step_03_DeepLoad_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				int count = -1;
				mock =  CreateMockInstance(tm);
				mockCollection = DataRepository.KetQuaCacKhoanChiKhacProvider.GetPaged(tm, 0, 10, out count);
			
				DataRepository.KetQuaCacKhoanChiKhacProvider.DeepLoading += new EntityProviderBaseCore<KetQuaCacKhoanChiKhac, KetQuaCacKhoanChiKhacKey>.DeepLoadingEventHandler(
						delegate(object sender, DeepSessionEventArgs e)
						{
							if (e.DeepSession.Count > 3)
								e.Cancel = true;
						}
					);

				if (mockCollection.Count > 0)
				{
					
					DataRepository.KetQuaCacKhoanChiKhacProvider.DeepLoad(tm, mockCollection[0]);
					System.Console.WriteLine("KetQuaCacKhoanChiKhac instance correctly deep loaded at 1 level.");
									
					mockCollection.Add(mock);
					// DataRepository.KetQuaCacKhoanChiKhacProvider.DeepSave(tm, mockCollection);
				}
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		/// <summary>
		/// Updates a mock KetQuaCacKhoanChiKhac entity into the database.
		/// </summary>
		private void Step_04_Update_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				KetQuaCacKhoanChiKhac mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.KetQuaCacKhoanChiKhacProvider.Insert(tm, mock), "Insert failed");
				
				UpdateMockInstance(tm, mock);
				Assert.IsTrue(DataRepository.KetQuaCacKhoanChiKhacProvider.Update(tm, mock), "Update failed.");			
				
				System.Console.WriteLine("DataRepository.KetQuaCacKhoanChiKhacProvider.Update(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Delete the mock KetQuaCacKhoanChiKhac entity into the database.
		/// </summary>
		private void Step_05_Delete_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  (KetQuaCacKhoanChiKhac)CreateMockInstance(tm);
				DataRepository.KetQuaCacKhoanChiKhacProvider.Insert(tm, mock);
			
				Assert.IsTrue(DataRepository.KetQuaCacKhoanChiKhacProvider.Delete(tm, mock), "Delete failed.");
				System.Console.WriteLine("DataRepository.KetQuaCacKhoanChiKhacProvider.Delete(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		#region Serialization tests
		
		/// <summary>
		/// Serialize the mock KetQuaCacKhoanChiKhac entity into a temporary file.
		/// </summary>
		private void Step_06_SerializeEntity_Generated()
		{	
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  CreateMockInstance(tm);
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_KetQuaCacKhoanChiKhac.xml");
			
				EntityHelper.SerializeXml(mock, fileName);
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock not found");
					
				System.Console.WriteLine("mock correctly serialized to a temporary file.");			
			}
		}
		
		/// <summary>
		/// Deserialize the mock KetQuaCacKhoanChiKhac entity from a temporary file.
		/// </summary>
		private void Step_07_DeserializeEntity_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_KetQuaCacKhoanChiKhac.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			using (System.IO.StreamReader sr = System.IO.File.OpenText(fileName))
			{
				object item = EntityHelper.DeserializeEntityXml<KetQuaCacKhoanChiKhac>(sr.ReadToEnd());
				sr.Close();
			}
			System.IO.File.Delete(fileName);
			
			System.Console.WriteLine("mock correctly deserialized from a temporary file.");
		}
		
		/// <summary>
		/// Serialize a KetQuaCacKhoanChiKhac collection into a temporary file.
		/// </summary>
		private void Step_08_SerializeCollection_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_KetQuaCacKhoanChiKhacCollection.xml");
				
				mock = CreateMockInstance(tm);
				TList<KetQuaCacKhoanChiKhac> mockCollection = new TList<KetQuaCacKhoanChiKhac>();
				mockCollection.Add(mock);
			
				EntityHelper.SerializeXml(mockCollection, fileName);
				
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock collection not found");
				System.Console.WriteLine("TList<KetQuaCacKhoanChiKhac> correctly serialized to a temporary file.");					
			}
		}
		
		
		/// <summary>
		/// Deserialize a KetQuaCacKhoanChiKhac collection from a temporary file.
		/// </summary>
		private void Step_09_DeserializeCollection_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_KetQuaCacKhoanChiKhacCollection.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			XmlSerializer mySerializer = new XmlSerializer(typeof(TList<KetQuaCacKhoanChiKhac>)); 
			using (System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open))
			{
				TList<KetQuaCacKhoanChiKhac> mockCollection = (TList<KetQuaCacKhoanChiKhac>) mySerializer.Deserialize(myFileStream);
				myFileStream.Close();
			}
			
			System.IO.File.Delete(fileName);
			System.Console.WriteLine("TList<KetQuaCacKhoanChiKhac> correctly deserialized from a temporary file.");	
		}
		#endregion
		
		
		
		/// <summary>
		/// Check the foreign key dal methods.
		/// </summary>
		private void Step_10_FK_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				KetQuaCacKhoanChiKhac entity = CreateMockInstance(tm);
				bool result = DataRepository.KetQuaCacKhoanChiKhacProvider.Insert(tm, entity);
				
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
				KetQuaCacKhoanChiKhac entity = CreateMockInstance(tm);
				bool result = DataRepository.KetQuaCacKhoanChiKhacProvider.Insert(tm, entity);
				
				Assert.IsTrue(result, "Could Not Test IX, Insert Failed");

			
				KetQuaCacKhoanChiKhac t0 = DataRepository.KetQuaCacKhoanChiKhacProvider.GetById(tm, entity.Id);
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
				
				KetQuaCacKhoanChiKhac entity = mock.Copy() as KetQuaCacKhoanChiKhac;
				entity = (KetQuaCacKhoanChiKhac)mock.Clone();
				Assert.IsTrue(KetQuaCacKhoanChiKhac.ValueEquals(entity, mock), "Clone is not working");
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
				KetQuaCacKhoanChiKhac mock = CreateMockInstance(tm);
				bool result = DataRepository.KetQuaCacKhoanChiKhacProvider.Insert(tm, mock);
				
				Assert.IsTrue(result, "Could Not Test FindByQuery, Insert Failed");

				KetQuaCacKhoanChiKhacQuery query = new KetQuaCacKhoanChiKhacQuery();
			
				query.AppendEquals(KetQuaCacKhoanChiKhacColumn.Id, mock.Id.ToString());
				if(mock.MaGiangVienQuanLy != null)
					query.AppendEquals(KetQuaCacKhoanChiKhacColumn.MaGiangVienQuanLy, mock.MaGiangVienQuanLy.ToString());
				if(mock.Lop != null)
					query.AppendEquals(KetQuaCacKhoanChiKhacColumn.Lop, mock.Lop.ToString());
				if(mock.MaSo != null)
					query.AppendEquals(KetQuaCacKhoanChiKhacColumn.MaSo, mock.MaSo.ToString());
				if(mock.Ngay != null)
					query.AppendEquals(KetQuaCacKhoanChiKhacColumn.Ngay, mock.Ngay.ToString());
				if(mock.NoiDung != null)
					query.AppendEquals(KetQuaCacKhoanChiKhacColumn.NoiDung, mock.NoiDung.ToString());
				if(mock.HeSo != null)
					query.AppendEquals(KetQuaCacKhoanChiKhacColumn.HeSo, mock.HeSo.ToString());
				if(mock.SoTiet != null)
					query.AppendEquals(KetQuaCacKhoanChiKhacColumn.SoTiet, mock.SoTiet.ToString());
				if(mock.TienMotTiet != null)
					query.AppendEquals(KetQuaCacKhoanChiKhacColumn.TienMotTiet, mock.TienMotTiet.ToString());
				if(mock.ThanhTien != null)
					query.AppendEquals(KetQuaCacKhoanChiKhacColumn.ThanhTien, mock.ThanhTien.ToString());
				if(mock.PhiCongTac != null)
					query.AppendEquals(KetQuaCacKhoanChiKhacColumn.PhiCongTac, mock.PhiCongTac.ToString());
				if(mock.TienGiangNgoaiGio != null)
					query.AppendEquals(KetQuaCacKhoanChiKhacColumn.TienGiangNgoaiGio, mock.TienGiangNgoaiGio.ToString());
				if(mock.TongThanhTien != null)
					query.AppendEquals(KetQuaCacKhoanChiKhacColumn.TongThanhTien, mock.TongThanhTien.ToString());
				
				TList<KetQuaCacKhoanChiKhac> results = DataRepository.KetQuaCacKhoanChiKhacProvider.Find(tm, query);
				
				Assert.IsTrue(results.Count == 1, "Find is not working correctly.  Failed to find the mock instance");
			}
		}
						
		#region Mock Instance
		///<summary>
		///  Returns a Typed KetQuaCacKhoanChiKhac Entity with mock values.
		///</summary>
		static public KetQuaCacKhoanChiKhac CreateMockInstance_Generated(TransactionManager tm)
		{		
			KetQuaCacKhoanChiKhac mock = new KetQuaCacKhoanChiKhac();
						
			mock.MaGiangVienQuanLy = TestUtility.Instance.RandomString(9, false);;
			mock.Lop = TestUtility.Instance.RandomString(99, false);;
			mock.MaSo = TestUtility.Instance.RandomString(24, false);;
			mock.Ngay = TestUtility.Instance.RandomDateTime();
			mock.NoiDung = TestUtility.Instance.RandomString(249, false);;
			mock.HeSo = (decimal)TestUtility.Instance.RandomShort();
			mock.SoTiet = (decimal)TestUtility.Instance.RandomShort();
			mock.TienMotTiet = (decimal)TestUtility.Instance.RandomShort();
			mock.ThanhTien = (decimal)TestUtility.Instance.RandomShort();
			mock.PhiCongTac = (decimal)TestUtility.Instance.RandomShort();
			mock.TienGiangNgoaiGio = (decimal)TestUtility.Instance.RandomShort();
			mock.TongThanhTien = (decimal)TestUtility.Instance.RandomShort();
			
		
			// create a temporary collection and add the item to it
			TList<KetQuaCacKhoanChiKhac> tempMockCollection = new TList<KetQuaCacKhoanChiKhac>();
			tempMockCollection.Add(mock);
			tempMockCollection.Remove(mock);
			
		
		   return (KetQuaCacKhoanChiKhac)mock;
		}
		
		
		///<summary>
		///  Update the Typed KetQuaCacKhoanChiKhac Entity with modified mock values.
		///</summary>
		static public void UpdateMockInstance_Generated(TransactionManager tm, KetQuaCacKhoanChiKhac mock)
		{
			mock.MaGiangVienQuanLy = TestUtility.Instance.RandomString(9, false);;
			mock.Lop = TestUtility.Instance.RandomString(99, false);;
			mock.MaSo = TestUtility.Instance.RandomString(24, false);;
			mock.Ngay = TestUtility.Instance.RandomDateTime();
			mock.NoiDung = TestUtility.Instance.RandomString(249, false);;
			mock.HeSo = (decimal)TestUtility.Instance.RandomShort();
			mock.SoTiet = (decimal)TestUtility.Instance.RandomShort();
			mock.TienMotTiet = (decimal)TestUtility.Instance.RandomShort();
			mock.ThanhTien = (decimal)TestUtility.Instance.RandomShort();
			mock.PhiCongTac = (decimal)TestUtility.Instance.RandomShort();
			mock.TienGiangNgoaiGio = (decimal)TestUtility.Instance.RandomShort();
			mock.TongThanhTien = (decimal)TestUtility.Instance.RandomShort();
			
		}
		#endregion
    }
}