﻿
/*
	File Generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file KetQuaDanhGiaVuotGioTest.cs instead.
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
    /// Provides tests for the and <see cref="KetQuaDanhGiaVuotGio"/> objects (entity, collection and repository).
    /// </summary>
   public partial class KetQuaDanhGiaVuotGioTest
    {
    	// the KetQuaDanhGiaVuotGio instance used to test the repository.
		protected KetQuaDanhGiaVuotGio mock;
		
		// the TList<KetQuaDanhGiaVuotGio> instance used to test the repository.
		protected TList<KetQuaDanhGiaVuotGio> mockCollection;
		
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
			System.Console.WriteLine("-- Testing the KetQuaDanhGiaVuotGio Entity with the {0} --", PMS.Data.DataRepository.Provider.Name);
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
		/// Inserts a mock KetQuaDanhGiaVuotGio entity into the database.
		/// </summary>
		private void Step_01_Insert_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.KetQuaDanhGiaVuotGioProvider.Insert(tm, mock), "Insert failed");
										
				System.Console.WriteLine("DataRepository.KetQuaDanhGiaVuotGioProvider.Insert(mock):");			
				System.Console.WriteLine(mock);			
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Selects all KetQuaDanhGiaVuotGio objects of the database.
		/// </summary>
		private void Step_02_SelectAll_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				//Find
				int count = -1;
				
				mockCollection = DataRepository.KetQuaDanhGiaVuotGioProvider.Find(tm, null, "", 0, 10, out count );
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue Find Command.");
				
				System.Console.WriteLine("DataRepository.KetQuaDanhGiaVuotGioProvider.Find():");			
				System.Console.WriteLine(mockCollection);
				
				// GetPaged
				count = -1;
				
				mockCollection = DataRepository.KetQuaDanhGiaVuotGioProvider.GetPaged(tm, 0, 10, out count);
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue GetPaged Command.");
				System.Console.WriteLine("#get paged count: " + count.ToString());
			}
		}
		
		
		
		
		/// <summary>
		/// Deep load all KetQuaDanhGiaVuotGio children.
		/// </summary>
		private void Step_03_DeepLoad_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				int count = -1;
				mock =  CreateMockInstance(tm);
				mockCollection = DataRepository.KetQuaDanhGiaVuotGioProvider.GetPaged(tm, 0, 10, out count);
			
				DataRepository.KetQuaDanhGiaVuotGioProvider.DeepLoading += new EntityProviderBaseCore<KetQuaDanhGiaVuotGio, KetQuaDanhGiaVuotGioKey>.DeepLoadingEventHandler(
						delegate(object sender, DeepSessionEventArgs e)
						{
							if (e.DeepSession.Count > 3)
								e.Cancel = true;
						}
					);

				if (mockCollection.Count > 0)
				{
					
					DataRepository.KetQuaDanhGiaVuotGioProvider.DeepLoad(tm, mockCollection[0]);
					System.Console.WriteLine("KetQuaDanhGiaVuotGio instance correctly deep loaded at 1 level.");
									
					mockCollection.Add(mock);
					// DataRepository.KetQuaDanhGiaVuotGioProvider.DeepSave(tm, mockCollection);
				}
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		/// <summary>
		/// Updates a mock KetQuaDanhGiaVuotGio entity into the database.
		/// </summary>
		private void Step_04_Update_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				KetQuaDanhGiaVuotGio mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.KetQuaDanhGiaVuotGioProvider.Insert(tm, mock), "Insert failed");
				
				UpdateMockInstance(tm, mock);
				Assert.IsTrue(DataRepository.KetQuaDanhGiaVuotGioProvider.Update(tm, mock), "Update failed.");			
				
				System.Console.WriteLine("DataRepository.KetQuaDanhGiaVuotGioProvider.Update(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Delete the mock KetQuaDanhGiaVuotGio entity into the database.
		/// </summary>
		private void Step_05_Delete_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  (KetQuaDanhGiaVuotGio)CreateMockInstance(tm);
				DataRepository.KetQuaDanhGiaVuotGioProvider.Insert(tm, mock);
			
				Assert.IsTrue(DataRepository.KetQuaDanhGiaVuotGioProvider.Delete(tm, mock), "Delete failed.");
				System.Console.WriteLine("DataRepository.KetQuaDanhGiaVuotGioProvider.Delete(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		#region Serialization tests
		
		/// <summary>
		/// Serialize the mock KetQuaDanhGiaVuotGio entity into a temporary file.
		/// </summary>
		private void Step_06_SerializeEntity_Generated()
		{	
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  CreateMockInstance(tm);
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_KetQuaDanhGiaVuotGio.xml");
			
				EntityHelper.SerializeXml(mock, fileName);
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock not found");
					
				System.Console.WriteLine("mock correctly serialized to a temporary file.");			
			}
		}
		
		/// <summary>
		/// Deserialize the mock KetQuaDanhGiaVuotGio entity from a temporary file.
		/// </summary>
		private void Step_07_DeserializeEntity_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_KetQuaDanhGiaVuotGio.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			using (System.IO.StreamReader sr = System.IO.File.OpenText(fileName))
			{
				object item = EntityHelper.DeserializeEntityXml<KetQuaDanhGiaVuotGio>(sr.ReadToEnd());
				sr.Close();
			}
			System.IO.File.Delete(fileName);
			
			System.Console.WriteLine("mock correctly deserialized from a temporary file.");
		}
		
		/// <summary>
		/// Serialize a KetQuaDanhGiaVuotGio collection into a temporary file.
		/// </summary>
		private void Step_08_SerializeCollection_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_KetQuaDanhGiaVuotGioCollection.xml");
				
				mock = CreateMockInstance(tm);
				TList<KetQuaDanhGiaVuotGio> mockCollection = new TList<KetQuaDanhGiaVuotGio>();
				mockCollection.Add(mock);
			
				EntityHelper.SerializeXml(mockCollection, fileName);
				
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock collection not found");
				System.Console.WriteLine("TList<KetQuaDanhGiaVuotGio> correctly serialized to a temporary file.");					
			}
		}
		
		
		/// <summary>
		/// Deserialize a KetQuaDanhGiaVuotGio collection from a temporary file.
		/// </summary>
		private void Step_09_DeserializeCollection_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_KetQuaDanhGiaVuotGioCollection.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			XmlSerializer mySerializer = new XmlSerializer(typeof(TList<KetQuaDanhGiaVuotGio>)); 
			using (System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open))
			{
				TList<KetQuaDanhGiaVuotGio> mockCollection = (TList<KetQuaDanhGiaVuotGio>) mySerializer.Deserialize(myFileStream);
				myFileStream.Close();
			}
			
			System.IO.File.Delete(fileName);
			System.Console.WriteLine("TList<KetQuaDanhGiaVuotGio> correctly deserialized from a temporary file.");	
		}
		#endregion
		
		
		
		/// <summary>
		/// Check the foreign key dal methods.
		/// </summary>
		private void Step_10_FK_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				KetQuaDanhGiaVuotGio entity = CreateMockInstance(tm);
				bool result = DataRepository.KetQuaDanhGiaVuotGioProvider.Insert(tm, entity);
				
				Assert.IsTrue(result, "Could Not Test FK, Insert Failed");
				
				TList<KetQuaDanhGiaVuotGio> t0 = DataRepository.KetQuaDanhGiaVuotGioProvider.GetByMaNoiDungDanhGia(tm, entity.MaNoiDungDanhGia, 0, 10);
			}
		}
		
		
		/// <summary>
		/// Check the indexes dal methods.
		/// </summary>
		private void Step_11_IX_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				KetQuaDanhGiaVuotGio entity = CreateMockInstance(tm);
				bool result = DataRepository.KetQuaDanhGiaVuotGioProvider.Insert(tm, entity);
				
				Assert.IsTrue(result, "Could Not Test IX, Insert Failed");

			
				KetQuaDanhGiaVuotGio t0 = DataRepository.KetQuaDanhGiaVuotGioProvider.GetById(tm, entity.Id);
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
				
				KetQuaDanhGiaVuotGio entity = mock.Copy() as KetQuaDanhGiaVuotGio;
				entity = (KetQuaDanhGiaVuotGio)mock.Clone();
				Assert.IsTrue(KetQuaDanhGiaVuotGio.ValueEquals(entity, mock), "Clone is not working");
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
				KetQuaDanhGiaVuotGio mock = CreateMockInstance(tm);
				bool result = DataRepository.KetQuaDanhGiaVuotGioProvider.Insert(tm, mock);
				
				Assert.IsTrue(result, "Could Not Test FindByQuery, Insert Failed");

				KetQuaDanhGiaVuotGioQuery query = new KetQuaDanhGiaVuotGioQuery();
			
				query.AppendEquals(KetQuaDanhGiaVuotGioColumn.Id, mock.Id.ToString());
				if(mock.NamHoc != null)
					query.AppendEquals(KetQuaDanhGiaVuotGioColumn.NamHoc, mock.NamHoc.ToString());
				if(mock.MaGiangVien != null)
					query.AppendEquals(KetQuaDanhGiaVuotGioColumn.MaGiangVien, mock.MaGiangVien.ToString());
				if(mock.MaNoiDungDanhGia != null)
					query.AppendEquals(KetQuaDanhGiaVuotGioColumn.MaNoiDungDanhGia, mock.MaNoiDungDanhGia.ToString());
				if(mock.ThoiGianLamViecQuyDinh != null)
					query.AppendEquals(KetQuaDanhGiaVuotGioColumn.ThoiGianLamViecQuyDinh, mock.ThoiGianLamViecQuyDinh.ToString());
				if(mock.DanhGiaThoiGianThucHien != null)
					query.AppendEquals(KetQuaDanhGiaVuotGioColumn.DanhGiaThoiGianThucHien, mock.DanhGiaThoiGianThucHien.ToString());
				if(mock.PhanTramDanhGia != null)
					query.AppendEquals(KetQuaDanhGiaVuotGioColumn.PhanTramDanhGia, mock.PhanTramDanhGia.ToString());
				if(mock.GhiChu != null)
					query.AppendEquals(KetQuaDanhGiaVuotGioColumn.GhiChu, mock.GhiChu.ToString());
				if(mock.NgayCapNhat != null)
					query.AppendEquals(KetQuaDanhGiaVuotGioColumn.NgayCapNhat, mock.NgayCapNhat.ToString());
				if(mock.NguoiCapNhat != null)
					query.AppendEquals(KetQuaDanhGiaVuotGioColumn.NguoiCapNhat, mock.NguoiCapNhat.ToString());
				
				TList<KetQuaDanhGiaVuotGio> results = DataRepository.KetQuaDanhGiaVuotGioProvider.Find(tm, query);
				
				Assert.IsTrue(results.Count == 1, "Find is not working correctly.  Failed to find the mock instance");
			}
		}
						
		#region Mock Instance
		///<summary>
		///  Returns a Typed KetQuaDanhGiaVuotGio Entity with mock values.
		///</summary>
		static public KetQuaDanhGiaVuotGio CreateMockInstance_Generated(TransactionManager tm)
		{		
			KetQuaDanhGiaVuotGio mock = new KetQuaDanhGiaVuotGio();
						
			mock.NamHoc = TestUtility.Instance.RandomString(9, false);;
			mock.MaGiangVien = TestUtility.Instance.RandomNumber();
			mock.ThoiGianLamViecQuyDinh = (decimal)TestUtility.Instance.RandomShort();
			mock.DanhGiaThoiGianThucHien = (decimal)TestUtility.Instance.RandomShort();
			mock.PhanTramDanhGia = (decimal)TestUtility.Instance.RandomShort();
			mock.GhiChu = TestUtility.Instance.RandomString(249, false);;
			mock.NgayCapNhat = TestUtility.Instance.RandomString(24, false);;
			mock.NguoiCapNhat = TestUtility.Instance.RandomString(24, false);;
			
			//OneToOneRelationship
			NoiDungDanhGia mockNoiDungDanhGiaByMaNoiDungDanhGia = NoiDungDanhGiaTest.CreateMockInstance(tm);
			DataRepository.NoiDungDanhGiaProvider.Insert(tm, mockNoiDungDanhGiaByMaNoiDungDanhGia);
			mock.MaNoiDungDanhGia = mockNoiDungDanhGiaByMaNoiDungDanhGia.MaQuanLy;
		
			// create a temporary collection and add the item to it
			TList<KetQuaDanhGiaVuotGio> tempMockCollection = new TList<KetQuaDanhGiaVuotGio>();
			tempMockCollection.Add(mock);
			tempMockCollection.Remove(mock);
			
		
		   return (KetQuaDanhGiaVuotGio)mock;
		}
		
		
		///<summary>
		///  Update the Typed KetQuaDanhGiaVuotGio Entity with modified mock values.
		///</summary>
		static public void UpdateMockInstance_Generated(TransactionManager tm, KetQuaDanhGiaVuotGio mock)
		{
			mock.NamHoc = TestUtility.Instance.RandomString(9, false);;
			mock.MaGiangVien = TestUtility.Instance.RandomNumber();
			mock.ThoiGianLamViecQuyDinh = (decimal)TestUtility.Instance.RandomShort();
			mock.DanhGiaThoiGianThucHien = (decimal)TestUtility.Instance.RandomShort();
			mock.PhanTramDanhGia = (decimal)TestUtility.Instance.RandomShort();
			mock.GhiChu = TestUtility.Instance.RandomString(249, false);;
			mock.NgayCapNhat = TestUtility.Instance.RandomString(24, false);;
			mock.NguoiCapNhat = TestUtility.Instance.RandomString(24, false);;
			
			//OneToOneRelationship
			NoiDungDanhGia mockNoiDungDanhGiaByMaNoiDungDanhGia = NoiDungDanhGiaTest.CreateMockInstance(tm);
			DataRepository.NoiDungDanhGiaProvider.Insert(tm, mockNoiDungDanhGiaByMaNoiDungDanhGia);
			mock.MaNoiDungDanhGia = mockNoiDungDanhGiaByMaNoiDungDanhGia.MaQuanLy;
					
		}
		#endregion
    }
}
