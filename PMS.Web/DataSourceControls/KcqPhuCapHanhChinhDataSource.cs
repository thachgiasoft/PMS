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
	/// Represents the DataRepository.KcqPhuCapHanhChinhProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(KcqPhuCapHanhChinhDataSourceDesigner))]
	public class KcqPhuCapHanhChinhDataSource : ProviderDataSource<KcqPhuCapHanhChinh, KcqPhuCapHanhChinhKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KcqPhuCapHanhChinhDataSource class.
		/// </summary>
		public KcqPhuCapHanhChinhDataSource() : base(new KcqPhuCapHanhChinhService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the KcqPhuCapHanhChinhDataSourceView used by the KcqPhuCapHanhChinhDataSource.
		/// </summary>
		protected KcqPhuCapHanhChinhDataSourceView KcqPhuCapHanhChinhView
		{
			get { return ( View as KcqPhuCapHanhChinhDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the KcqPhuCapHanhChinhDataSource control invokes to retrieve data.
		/// </summary>
		public KcqPhuCapHanhChinhSelectMethod SelectMethod
		{
			get
			{
				KcqPhuCapHanhChinhSelectMethod selectMethod = KcqPhuCapHanhChinhSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (KcqPhuCapHanhChinhSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the KcqPhuCapHanhChinhDataSourceView class that is to be
		/// used by the KcqPhuCapHanhChinhDataSource.
		/// </summary>
		/// <returns>An instance of the KcqPhuCapHanhChinhDataSourceView class.</returns>
		protected override BaseDataSourceView<KcqPhuCapHanhChinh, KcqPhuCapHanhChinhKey> GetNewDataSourceView()
		{
			return new KcqPhuCapHanhChinhDataSourceView(this, DefaultViewName);
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
	/// Supports the KcqPhuCapHanhChinhDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class KcqPhuCapHanhChinhDataSourceView : ProviderDataSourceView<KcqPhuCapHanhChinh, KcqPhuCapHanhChinhKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KcqPhuCapHanhChinhDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the KcqPhuCapHanhChinhDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public KcqPhuCapHanhChinhDataSourceView(KcqPhuCapHanhChinhDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal KcqPhuCapHanhChinhDataSource KcqPhuCapHanhChinhOwner
		{
			get { return Owner as KcqPhuCapHanhChinhDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal KcqPhuCapHanhChinhSelectMethod SelectMethod
		{
			get { return KcqPhuCapHanhChinhOwner.SelectMethod; }
			set { KcqPhuCapHanhChinhOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal KcqPhuCapHanhChinhService KcqPhuCapHanhChinhProvider
		{
			get { return Provider as KcqPhuCapHanhChinhService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<KcqPhuCapHanhChinh> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<KcqPhuCapHanhChinh> results = null;
			KcqPhuCapHanhChinh item;
			count = 0;
			
			System.Int32 _id;

			switch ( SelectMethod )
			{
				case KcqPhuCapHanhChinhSelectMethod.Get:
					KcqPhuCapHanhChinhKey entityKey  = new KcqPhuCapHanhChinhKey();
					entityKey.Load(values);
					item = KcqPhuCapHanhChinhProvider.Get(entityKey);
					results = new TList<KcqPhuCapHanhChinh>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case KcqPhuCapHanhChinhSelectMethod.GetAll:
                    results = KcqPhuCapHanhChinhProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case KcqPhuCapHanhChinhSelectMethod.GetPaged:
					results = KcqPhuCapHanhChinhProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case KcqPhuCapHanhChinhSelectMethod.Find:
					if ( FilterParameters != null )
						results = KcqPhuCapHanhChinhProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = KcqPhuCapHanhChinhProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case KcqPhuCapHanhChinhSelectMethod.GetById:
					_id = ( values["Id"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["Id"], typeof(System.Int32)) : (int)0;
					item = KcqPhuCapHanhChinhProvider.GetById(_id);
					results = new TList<KcqPhuCapHanhChinh>();
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
			if ( SelectMethod == KcqPhuCapHanhChinhSelectMethod.Get || SelectMethod == KcqPhuCapHanhChinhSelectMethod.GetById )
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
				KcqPhuCapHanhChinh entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					KcqPhuCapHanhChinhProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<KcqPhuCapHanhChinh> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			KcqPhuCapHanhChinhProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region KcqPhuCapHanhChinhDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the KcqPhuCapHanhChinhDataSource class.
	/// </summary>
	public class KcqPhuCapHanhChinhDataSourceDesigner : ProviderDataSourceDesigner<KcqPhuCapHanhChinh, KcqPhuCapHanhChinhKey>
	{
		/// <summary>
		/// Initializes a new instance of the KcqPhuCapHanhChinhDataSourceDesigner class.
		/// </summary>
		public KcqPhuCapHanhChinhDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public KcqPhuCapHanhChinhSelectMethod SelectMethod
		{
			get { return ((KcqPhuCapHanhChinhDataSource) DataSource).SelectMethod; }
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
				actions.Add(new KcqPhuCapHanhChinhDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region KcqPhuCapHanhChinhDataSourceActionList

	/// <summary>
	/// Supports the KcqPhuCapHanhChinhDataSourceDesigner class.
	/// </summary>
	internal class KcqPhuCapHanhChinhDataSourceActionList : DesignerActionList
	{
		private KcqPhuCapHanhChinhDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the KcqPhuCapHanhChinhDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public KcqPhuCapHanhChinhDataSourceActionList(KcqPhuCapHanhChinhDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public KcqPhuCapHanhChinhSelectMethod SelectMethod
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

	#endregion KcqPhuCapHanhChinhDataSourceActionList
	
	#endregion KcqPhuCapHanhChinhDataSourceDesigner
	
	#region KcqPhuCapHanhChinhSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the KcqPhuCapHanhChinhDataSource.SelectMethod property.
	/// </summary>
	public enum KcqPhuCapHanhChinhSelectMethod
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
		/// Represents the GetById method.
		/// </summary>
		GetById
	}
	
	#endregion KcqPhuCapHanhChinhSelectMethod

	#region KcqPhuCapHanhChinhFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KcqPhuCapHanhChinh"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KcqPhuCapHanhChinhFilter : SqlFilter<KcqPhuCapHanhChinhColumn>
	{
	}
	
	#endregion KcqPhuCapHanhChinhFilter

	#region KcqPhuCapHanhChinhExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KcqPhuCapHanhChinh"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KcqPhuCapHanhChinhExpressionBuilder : SqlExpressionBuilder<KcqPhuCapHanhChinhColumn>
	{
	}
	
	#endregion KcqPhuCapHanhChinhExpressionBuilder	

	#region KcqPhuCapHanhChinhProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;KcqPhuCapHanhChinhChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="KcqPhuCapHanhChinh"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KcqPhuCapHanhChinhProperty : ChildEntityProperty<KcqPhuCapHanhChinhChildEntityTypes>
	{
	}
	
	#endregion KcqPhuCapHanhChinhProperty
}
