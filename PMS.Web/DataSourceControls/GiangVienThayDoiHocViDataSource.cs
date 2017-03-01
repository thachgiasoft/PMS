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
	/// Represents the DataRepository.GiangVienThayDoiHocViProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(GiangVienThayDoiHocViDataSourceDesigner))]
	public class GiangVienThayDoiHocViDataSource : ProviderDataSource<GiangVienThayDoiHocVi, GiangVienThayDoiHocViKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GiangVienThayDoiHocViDataSource class.
		/// </summary>
		public GiangVienThayDoiHocViDataSource() : base(new GiangVienThayDoiHocViService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the GiangVienThayDoiHocViDataSourceView used by the GiangVienThayDoiHocViDataSource.
		/// </summary>
		protected GiangVienThayDoiHocViDataSourceView GiangVienThayDoiHocViView
		{
			get { return ( View as GiangVienThayDoiHocViDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the GiangVienThayDoiHocViDataSource control invokes to retrieve data.
		/// </summary>
		public GiangVienThayDoiHocViSelectMethod SelectMethod
		{
			get
			{
				GiangVienThayDoiHocViSelectMethod selectMethod = GiangVienThayDoiHocViSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (GiangVienThayDoiHocViSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the GiangVienThayDoiHocViDataSourceView class that is to be
		/// used by the GiangVienThayDoiHocViDataSource.
		/// </summary>
		/// <returns>An instance of the GiangVienThayDoiHocViDataSourceView class.</returns>
		protected override BaseDataSourceView<GiangVienThayDoiHocVi, GiangVienThayDoiHocViKey> GetNewDataSourceView()
		{
			return new GiangVienThayDoiHocViDataSourceView(this, DefaultViewName);
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
	/// Supports the GiangVienThayDoiHocViDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class GiangVienThayDoiHocViDataSourceView : ProviderDataSourceView<GiangVienThayDoiHocVi, GiangVienThayDoiHocViKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GiangVienThayDoiHocViDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the GiangVienThayDoiHocViDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public GiangVienThayDoiHocViDataSourceView(GiangVienThayDoiHocViDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal GiangVienThayDoiHocViDataSource GiangVienThayDoiHocViOwner
		{
			get { return Owner as GiangVienThayDoiHocViDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal GiangVienThayDoiHocViSelectMethod SelectMethod
		{
			get { return GiangVienThayDoiHocViOwner.SelectMethod; }
			set { GiangVienThayDoiHocViOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal GiangVienThayDoiHocViService GiangVienThayDoiHocViProvider
		{
			get { return Provider as GiangVienThayDoiHocViService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<GiangVienThayDoiHocVi> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<GiangVienThayDoiHocVi> results = null;
			GiangVienThayDoiHocVi item;
			count = 0;
			
			System.Int32 _maQuanLy;

			switch ( SelectMethod )
			{
				case GiangVienThayDoiHocViSelectMethod.Get:
					GiangVienThayDoiHocViKey entityKey  = new GiangVienThayDoiHocViKey();
					entityKey.Load(values);
					item = GiangVienThayDoiHocViProvider.Get(entityKey);
					results = new TList<GiangVienThayDoiHocVi>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case GiangVienThayDoiHocViSelectMethod.GetAll:
                    results = GiangVienThayDoiHocViProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case GiangVienThayDoiHocViSelectMethod.GetPaged:
					results = GiangVienThayDoiHocViProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case GiangVienThayDoiHocViSelectMethod.Find:
					if ( FilterParameters != null )
						results = GiangVienThayDoiHocViProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = GiangVienThayDoiHocViProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case GiangVienThayDoiHocViSelectMethod.GetByMaQuanLy:
					_maQuanLy = ( values["MaQuanLy"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["MaQuanLy"], typeof(System.Int32)) : (int)0;
					item = GiangVienThayDoiHocViProvider.GetByMaQuanLy(_maQuanLy);
					results = new TList<GiangVienThayDoiHocVi>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				// FK
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
			if ( SelectMethod == GiangVienThayDoiHocViSelectMethod.Get || SelectMethod == GiangVienThayDoiHocViSelectMethod.GetByMaQuanLy )
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
				GiangVienThayDoiHocVi entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					GiangVienThayDoiHocViProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<GiangVienThayDoiHocVi> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			GiangVienThayDoiHocViProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region GiangVienThayDoiHocViDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the GiangVienThayDoiHocViDataSource class.
	/// </summary>
	public class GiangVienThayDoiHocViDataSourceDesigner : ProviderDataSourceDesigner<GiangVienThayDoiHocVi, GiangVienThayDoiHocViKey>
	{
		/// <summary>
		/// Initializes a new instance of the GiangVienThayDoiHocViDataSourceDesigner class.
		/// </summary>
		public GiangVienThayDoiHocViDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public GiangVienThayDoiHocViSelectMethod SelectMethod
		{
			get { return ((GiangVienThayDoiHocViDataSource) DataSource).SelectMethod; }
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
				actions.Add(new GiangVienThayDoiHocViDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region GiangVienThayDoiHocViDataSourceActionList

	/// <summary>
	/// Supports the GiangVienThayDoiHocViDataSourceDesigner class.
	/// </summary>
	internal class GiangVienThayDoiHocViDataSourceActionList : DesignerActionList
	{
		private GiangVienThayDoiHocViDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the GiangVienThayDoiHocViDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public GiangVienThayDoiHocViDataSourceActionList(GiangVienThayDoiHocViDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public GiangVienThayDoiHocViSelectMethod SelectMethod
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

	#endregion GiangVienThayDoiHocViDataSourceActionList
	
	#endregion GiangVienThayDoiHocViDataSourceDesigner
	
	#region GiangVienThayDoiHocViSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the GiangVienThayDoiHocViDataSource.SelectMethod property.
	/// </summary>
	public enum GiangVienThayDoiHocViSelectMethod
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
		/// Represents the GetByMaQuanLy method.
		/// </summary>
		GetByMaQuanLy
	}
	
	#endregion GiangVienThayDoiHocViSelectMethod

	#region GiangVienThayDoiHocViFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GiangVienThayDoiHocVi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GiangVienThayDoiHocViFilter : SqlFilter<GiangVienThayDoiHocViColumn>
	{
	}
	
	#endregion GiangVienThayDoiHocViFilter

	#region GiangVienThayDoiHocViExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GiangVienThayDoiHocVi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GiangVienThayDoiHocViExpressionBuilder : SqlExpressionBuilder<GiangVienThayDoiHocViColumn>
	{
	}
	
	#endregion GiangVienThayDoiHocViExpressionBuilder	

	#region GiangVienThayDoiHocViProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;GiangVienThayDoiHocViChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="GiangVienThayDoiHocVi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GiangVienThayDoiHocViProperty : ChildEntityProperty<GiangVienThayDoiHocViChildEntityTypes>
	{
	}
	
	#endregion GiangVienThayDoiHocViProperty
}

