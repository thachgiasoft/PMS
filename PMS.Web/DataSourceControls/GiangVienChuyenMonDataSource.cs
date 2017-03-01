﻿#region Using Directives
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
	/// Represents the DataRepository.GiangVienChuyenMonProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(GiangVienChuyenMonDataSourceDesigner))]
	public class GiangVienChuyenMonDataSource : ProviderDataSource<GiangVienChuyenMon, GiangVienChuyenMonKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GiangVienChuyenMonDataSource class.
		/// </summary>
		public GiangVienChuyenMonDataSource() : base(new GiangVienChuyenMonService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the GiangVienChuyenMonDataSourceView used by the GiangVienChuyenMonDataSource.
		/// </summary>
		protected GiangVienChuyenMonDataSourceView GiangVienChuyenMonView
		{
			get { return ( View as GiangVienChuyenMonDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the GiangVienChuyenMonDataSource control invokes to retrieve data.
		/// </summary>
		public GiangVienChuyenMonSelectMethod SelectMethod
		{
			get
			{
				GiangVienChuyenMonSelectMethod selectMethod = GiangVienChuyenMonSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (GiangVienChuyenMonSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the GiangVienChuyenMonDataSourceView class that is to be
		/// used by the GiangVienChuyenMonDataSource.
		/// </summary>
		/// <returns>An instance of the GiangVienChuyenMonDataSourceView class.</returns>
		protected override BaseDataSourceView<GiangVienChuyenMon, GiangVienChuyenMonKey> GetNewDataSourceView()
		{
			return new GiangVienChuyenMonDataSourceView(this, DefaultViewName);
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
	/// Supports the GiangVienChuyenMonDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class GiangVienChuyenMonDataSourceView : ProviderDataSourceView<GiangVienChuyenMon, GiangVienChuyenMonKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GiangVienChuyenMonDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the GiangVienChuyenMonDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public GiangVienChuyenMonDataSourceView(GiangVienChuyenMonDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal GiangVienChuyenMonDataSource GiangVienChuyenMonOwner
		{
			get { return Owner as GiangVienChuyenMonDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal GiangVienChuyenMonSelectMethod SelectMethod
		{
			get { return GiangVienChuyenMonOwner.SelectMethod; }
			set { GiangVienChuyenMonOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal GiangVienChuyenMonService GiangVienChuyenMonProvider
		{
			get { return Provider as GiangVienChuyenMonService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<GiangVienChuyenMon> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<GiangVienChuyenMon> results = null;
			GiangVienChuyenMon item;
			count = 0;
			
			System.Int32? _maGiangVien_nullable;
			System.String _maMonHoc_nullable;
			System.Int32 _maPhanCong;

			switch ( SelectMethod )
			{
				case GiangVienChuyenMonSelectMethod.Get:
					GiangVienChuyenMonKey entityKey  = new GiangVienChuyenMonKey();
					entityKey.Load(values);
					item = GiangVienChuyenMonProvider.Get(entityKey);
					results = new TList<GiangVienChuyenMon>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case GiangVienChuyenMonSelectMethod.GetAll:
                    results = GiangVienChuyenMonProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case GiangVienChuyenMonSelectMethod.GetPaged:
					results = GiangVienChuyenMonProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case GiangVienChuyenMonSelectMethod.Find:
					if ( FilterParameters != null )
						results = GiangVienChuyenMonProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = GiangVienChuyenMonProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case GiangVienChuyenMonSelectMethod.GetByMaPhanCong:
					_maPhanCong = ( values["MaPhanCong"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["MaPhanCong"], typeof(System.Int32)) : (int)0;
					item = GiangVienChuyenMonProvider.GetByMaPhanCong(_maPhanCong);
					results = new TList<GiangVienChuyenMon>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				case GiangVienChuyenMonSelectMethod.GetByMaGiangVienMaMonHoc:
					_maGiangVien_nullable = (System.Int32?) EntityUtil.ChangeType(values["MaGiangVien"], typeof(System.Int32?));
					_maMonHoc_nullable = (System.String) EntityUtil.ChangeType(values["MaMonHoc"], typeof(System.String));
					item = GiangVienChuyenMonProvider.GetByMaGiangVienMaMonHoc(_maGiangVien_nullable, _maMonHoc_nullable);
					results = new TList<GiangVienChuyenMon>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// FK
				case GiangVienChuyenMonSelectMethod.GetByMaGiangVien:
					_maGiangVien_nullable = (System.Int32?) EntityUtil.ChangeType(values["MaGiangVien"], typeof(System.Int32?));
					results = GiangVienChuyenMonProvider.GetByMaGiangVien(_maGiangVien_nullable, this.StartIndex, this.PageSize, out count);
					break;
				// M:M
				// Custom
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
			if ( SelectMethod == GiangVienChuyenMonSelectMethod.Get || SelectMethod == GiangVienChuyenMonSelectMethod.GetByMaPhanCong )
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
				GiangVienChuyenMon entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					GiangVienChuyenMonProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<GiangVienChuyenMon> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			GiangVienChuyenMonProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region GiangVienChuyenMonDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the GiangVienChuyenMonDataSource class.
	/// </summary>
	public class GiangVienChuyenMonDataSourceDesigner : ProviderDataSourceDesigner<GiangVienChuyenMon, GiangVienChuyenMonKey>
	{
		/// <summary>
		/// Initializes a new instance of the GiangVienChuyenMonDataSourceDesigner class.
		/// </summary>
		public GiangVienChuyenMonDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public GiangVienChuyenMonSelectMethod SelectMethod
		{
			get { return ((GiangVienChuyenMonDataSource) DataSource).SelectMethod; }
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
				actions.Add(new GiangVienChuyenMonDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region GiangVienChuyenMonDataSourceActionList

	/// <summary>
	/// Supports the GiangVienChuyenMonDataSourceDesigner class.
	/// </summary>
	internal class GiangVienChuyenMonDataSourceActionList : DesignerActionList
	{
		private GiangVienChuyenMonDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the GiangVienChuyenMonDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public GiangVienChuyenMonDataSourceActionList(GiangVienChuyenMonDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public GiangVienChuyenMonSelectMethod SelectMethod
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

	#endregion GiangVienChuyenMonDataSourceActionList
	
	#endregion GiangVienChuyenMonDataSourceDesigner
	
	#region GiangVienChuyenMonSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the GiangVienChuyenMonDataSource.SelectMethod property.
	/// </summary>
	public enum GiangVienChuyenMonSelectMethod
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
		/// Represents the GetByMaGiangVienMaMonHoc method.
		/// </summary>
		GetByMaGiangVienMaMonHoc,
		/// <summary>
		/// Represents the GetByMaPhanCong method.
		/// </summary>
		GetByMaPhanCong,
		/// <summary>
		/// Represents the GetByMaGiangVien method.
		/// </summary>
		GetByMaGiangVien
	}
	
	#endregion GiangVienChuyenMonSelectMethod

	#region GiangVienChuyenMonFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GiangVienChuyenMon"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GiangVienChuyenMonFilter : SqlFilter<GiangVienChuyenMonColumn>
	{
	}
	
	#endregion GiangVienChuyenMonFilter

	#region GiangVienChuyenMonExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GiangVienChuyenMon"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GiangVienChuyenMonExpressionBuilder : SqlExpressionBuilder<GiangVienChuyenMonColumn>
	{
	}
	
	#endregion GiangVienChuyenMonExpressionBuilder	

	#region GiangVienChuyenMonProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;GiangVienChuyenMonChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="GiangVienChuyenMon"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GiangVienChuyenMonProperty : ChildEntityProperty<GiangVienChuyenMonChildEntityTypes>
	{
	}
	
	#endregion GiangVienChuyenMonProperty
}

