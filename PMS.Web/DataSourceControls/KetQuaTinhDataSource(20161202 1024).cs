#region Using Directives
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Web.UI;
using System.Web.UI.Design;

using PMS.Entities;
using PMS.Data;
using PMS.Data.Bases;
using PMS.Services;
#endregion

namespace PMS.Web.Data
{
	/// <summary>
	/// Represents the DataRepository.KetQuaTinhProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(KetQuaTinhDataSourceDesigner))]
	public class KetQuaTinhDataSource : ProviderDataSource<KetQuaTinh, KetQuaTinhKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KetQuaTinhDataSource class.
		/// </summary>
		public KetQuaTinhDataSource() : base(new KetQuaTinhService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the KetQuaTinhDataSourceView used by the KetQuaTinhDataSource.
		/// </summary>
		protected KetQuaTinhDataSourceView KetQuaTinhView
		{
			get { return ( View as KetQuaTinhDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the KetQuaTinhDataSource control invokes to retrieve data.
		/// </summary>
		public KetQuaTinhSelectMethod SelectMethod
		{
			get
			{
				KetQuaTinhSelectMethod selectMethod = KetQuaTinhSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (KetQuaTinhSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the KetQuaTinhDataSourceView class that is to be
		/// used by the KetQuaTinhDataSource.
		/// </summary>
		/// <returns>An instance of the KetQuaTinhDataSourceView class.</returns>
		protected override BaseDataSourceView<KetQuaTinh, KetQuaTinhKey> GetNewDataSourceView()
		{
			return new KetQuaTinhDataSourceView(this, DefaultViewName);
		}
		
		/// <summary>
        /// Creates a cache hashing key based on the startIndex, pageSize and the SelectMethod being used.
        /// </summary>
        /// <param name="startIndex">The current start row index.</param>
        /// <param name="pageSize">The current page size.</param>
        /// <returns>A string that can be used as a key for caching purposes.</returns>
		protected override string CacheHashKey(int startIndex, int pageSize)
        {
			return String.Format("{0}:{1}:{2}", SelectMethod, startIndex, pageSize);
        }
		
		#endregion Methods
	}
	
	/// <summary>
	/// Supports the KetQuaTinhDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class KetQuaTinhDataSourceView : ProviderDataSourceView<KetQuaTinh, KetQuaTinhKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KetQuaTinhDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the KetQuaTinhDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public KetQuaTinhDataSourceView(KetQuaTinhDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal KetQuaTinhDataSource KetQuaTinhOwner
		{
			get { return Owner as KetQuaTinhDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal KetQuaTinhSelectMethod SelectMethod
		{
			get { return KetQuaTinhOwner.SelectMethod; }
			set { KetQuaTinhOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal KetQuaTinhService KetQuaTinhProvider
		{
			get { return Provider as KetQuaTinhService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<KetQuaTinh> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<KetQuaTinh> results = null;
			KetQuaTinh item;
			count = 0;
			
			System.Int32? _maGiangVien_nullable;
			System.String _namHoc_nullable;
			System.String _hocKy_nullable;
			System.Int32 _maKetQua;
			System.Int32? sp2637_MaGiangVien;
			System.String sp2637_NamHoc;
			System.String sp2637_HocKy;
			System.String sp2636_NamHoc;
			System.String sp2636_HocKy;

			switch ( SelectMethod )
			{
				case KetQuaTinhSelectMethod.Get:
					KetQuaTinhKey entityKey  = new KetQuaTinhKey();
					entityKey.Load(values);
					item = KetQuaTinhProvider.Get(entityKey);
					results = new TList<KetQuaTinh>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case KetQuaTinhSelectMethod.GetAll:
                    results = KetQuaTinhProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case KetQuaTinhSelectMethod.GetPaged:
					results = KetQuaTinhProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case KetQuaTinhSelectMethod.Find:
					if ( FilterParameters != null )
						results = KetQuaTinhProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = KetQuaTinhProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case KetQuaTinhSelectMethod.GetByMaKetQua:
					_maKetQua = ( values["MaKetQua"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["MaKetQua"], typeof(System.Int32)) : (int)0;
					item = KetQuaTinhProvider.GetByMaKetQua(_maKetQua);
					results = new TList<KetQuaTinh>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				case KetQuaTinhSelectMethod.GetByMaGiangVienNamHocHocKy:
					_maGiangVien_nullable = (System.Int32?) EntityUtil.ChangeType(values["MaGiangVien"], typeof(System.Int32?));
					_namHoc_nullable = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					_hocKy_nullable = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					item = KetQuaTinhProvider.GetByMaGiangVienNamHocHocKy(_maGiangVien_nullable, _namHoc_nullable, _hocKy_nullable);
					results = new TList<KetQuaTinh>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// FK
				case KetQuaTinhSelectMethod.GetByMaGiangVien:
					_maGiangVien_nullable = (System.Int32?) EntityUtil.ChangeType(values["MaGiangVien"], typeof(System.Int32?));
					results = KetQuaTinhProvider.GetByMaGiangVien(_maGiangVien_nullable, this.StartIndex, this.PageSize, out count);
					break;
				// M:M
				// Custom
				case KetQuaTinhSelectMethod.GetKetQuaByMaGiangVienNamHocHocKy:
					sp2637_MaGiangVien = (System.Int32?) EntityUtil.ChangeType(values["MaGiangVien"], typeof(System.Int32?));
					sp2637_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp2637_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					results = KetQuaTinhProvider.GetKetQuaByMaGiangVienNamHocHocKy(sp2637_MaGiangVien, sp2637_NamHoc, sp2637_HocKy, StartIndex, PageSize);
					break;
				case KetQuaTinhSelectMethod.GetByNamHocHocKy:
					sp2636_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp2636_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					results = KetQuaTinhProvider.GetByNamHocHocKy(sp2636_NamHoc, sp2636_HocKy, StartIndex, PageSize);
					break;
				default:
					break;
			}

			if ( results != null && count < 1 )
			{
				count = results.Count;

				if ( !String.IsNullOrEmpty(CustomMethodRecordCountParamName) )
				{
					object objCustomCount = EntityUtil.ChangeType(customOutput[CustomMethodRecordCountParamName], typeof(Int32));
					
					if ( objCustomCount != null )
					{
						count = (int) objCustomCount;
					}
				}
			}
			
			return results;
		}
		
		/// <summary>
		/// Gets the values of any supplied parameters for internal caching.
		/// </summary>
		/// <param name="values">An IDictionary object of name/value pairs.</param>
		protected override void GetSelectParameters(IDictionary values)
		{
			if ( SelectMethod == KetQuaTinhSelectMethod.Get || SelectMethod == KetQuaTinhSelectMethod.GetByMaKetQua )
			{
				EntityId = GetEntityKey(values);
			}
		}

		/// <summary>
		/// Performs a DeepLoad operation for the current entity if it has
		/// not already been performed.
		/// </summary>
		internal override void DeepLoad()
		{
			if ( !IsDeepLoaded )
			{
				KetQuaTinh entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					KetQuaTinhProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
					// set loaded flag
					IsDeepLoaded = true;
				}
			}
		}

		/// <summary>
		/// Performs a DeepLoad operation on the specified entity collection.
		/// </summary>
		/// <param name="entityList"></param>
		/// <param name="properties"></param>
		internal override void DeepLoad(TList<KetQuaTinh> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			KetQuaTinhProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region KetQuaTinhDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the KetQuaTinhDataSource class.
	/// </summary>
	public class KetQuaTinhDataSourceDesigner : ProviderDataSourceDesigner<KetQuaTinh, KetQuaTinhKey>
	{
		/// <summary>
		/// Initializes a new instance of the KetQuaTinhDataSourceDesigner class.
		/// </summary>
		public KetQuaTinhDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public KetQuaTinhSelectMethod SelectMethod
		{
			get { return ((KetQuaTinhDataSource) DataSource).SelectMethod; }
			set { SetPropertyValue("SelectMethod", value); }
		}

		/// <summary>Gets the designer action list collection for this designer.</summary>
		/// <returns>The <see cref="T:System.ComponentModel.Design.DesignerActionListCollection"/>
		/// associated with this designer.</returns>
		public override DesignerActionListCollection ActionLists
		{
			get
			{
				DesignerActionListCollection actions = new DesignerActionListCollection();
				actions.Add(new KetQuaTinhDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region KetQuaTinhDataSourceActionList

	/// <summary>
	/// Supports the KetQuaTinhDataSourceDesigner class.
	/// </summary>
	internal class KetQuaTinhDataSourceActionList : DesignerActionList
	{
		private KetQuaTinhDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the KetQuaTinhDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public KetQuaTinhDataSourceActionList(KetQuaTinhDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public KetQuaTinhSelectMethod SelectMethod
		{
			get { return _designer.SelectMethod; }
			set { _designer.SelectMethod = value; }
		}

		/// <summary>
		/// Returns the collection of <see cref="T:System.ComponentModel.Design.DesignerActionItem"/>
		/// objects contained in the list.
		/// </summary>
		/// <returns>A <see cref="T:System.ComponentModel.Design.DesignerActionItem"/>
		/// array that contains the items in this list.</returns>
		public override DesignerActionItemCollection GetSortedActionItems()
		{
			DesignerActionItemCollection items = new DesignerActionItemCollection();
			items.Add(new DesignerActionPropertyItem("SelectMethod", "Select Method", "Methods"));
			return items;
		}
	}

	#endregion KetQuaTinhDataSourceActionList
	
	#endregion KetQuaTinhDataSourceDesigner
	
	#region KetQuaTinhSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the KetQuaTinhDataSource.SelectMethod property.
	/// </summary>
	public enum KetQuaTinhSelectMethod
	{
		/// <summary>
		/// Represents the Get method.
		/// </summary>
		Get,
		/// <summary>
		/// Represents the GetAll method.
		/// </summary>
		GetAll,
		/// <summary>
		/// Represents the GetPaged method.
		/// </summary>
		GetPaged,
		/// <summary>
		/// Represents the Find method.
		/// </summary>
		Find,
		/// <summary>
		/// Represents the GetByMaGiangVienNamHocHocKy method.
		/// </summary>
		GetByMaGiangVienNamHocHocKy,
		/// <summary>
		/// Represents the GetByMaKetQua method.
		/// </summary>
		GetByMaKetQua,
		/// <summary>
		/// Represents the GetByMaGiangVien method.
		/// </summary>
		GetByMaGiangVien,
		/// <summary>
		/// Represents the GetKetQuaByMaGiangVienNamHocHocKy method.
		/// </summary>
		GetKetQuaByMaGiangVienNamHocHocKy,
		/// <summary>
		/// Represents the GetByNamHocHocKy method.
		/// </summary>
		GetByNamHocHocKy
	}
	
	#endregion KetQuaTinhSelectMethod

	#region KetQuaTinhFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KetQuaTinh"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KetQuaTinhFilter : SqlFilter<KetQuaTinhColumn>
	{
	}
	
	#endregion KetQuaTinhFilter

	#region KetQuaTinhExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KetQuaTinh"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KetQuaTinhExpressionBuilder : SqlExpressionBuilder<KetQuaTinhColumn>
	{
	}
	
	#endregion KetQuaTinhExpressionBuilder	

	#region KetQuaTinhProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;KetQuaTinhChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="KetQuaTinh"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KetQuaTinhProperty : ChildEntityProperty<KetQuaTinhChildEntityTypes>
	{
	}
	
	#endregion KetQuaTinhProperty
}

