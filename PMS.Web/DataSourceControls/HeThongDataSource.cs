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
	/// Represents the DataRepository.HeThongProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(HeThongDataSourceDesigner))]
	public class HeThongDataSource : ProviderDataSource<HeThong, HeThongKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HeThongDataSource class.
		/// </summary>
		public HeThongDataSource() : base(new HeThongService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the HeThongDataSourceView used by the HeThongDataSource.
		/// </summary>
		protected HeThongDataSourceView HeThongView
		{
			get { return ( View as HeThongDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the HeThongDataSource control invokes to retrieve data.
		/// </summary>
		public HeThongSelectMethod SelectMethod
		{
			get
			{
				HeThongSelectMethod selectMethod = HeThongSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (HeThongSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the HeThongDataSourceView class that is to be
		/// used by the HeThongDataSource.
		/// </summary>
		/// <returns>An instance of the HeThongDataSourceView class.</returns>
		protected override BaseDataSourceView<HeThong, HeThongKey> GetNewDataSourceView()
		{
			return new HeThongDataSourceView(this, DefaultViewName);
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
	/// Supports the HeThongDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class HeThongDataSourceView : ProviderDataSourceView<HeThong, HeThongKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HeThongDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the HeThongDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public HeThongDataSourceView(HeThongDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal HeThongDataSource HeThongOwner
		{
			get { return Owner as HeThongDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal HeThongSelectMethod SelectMethod
		{
			get { return HeThongOwner.SelectMethod; }
			set { HeThongOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal HeThongService HeThongProvider
		{
			get { return Provider as HeThongService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<HeThong> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<HeThong> results = null;
			HeThong item;
			count = 0;
			
			System.Int32 _userId;
			System.Int32 _parentId;

			switch ( SelectMethod )
			{
				case HeThongSelectMethod.Get:
					HeThongKey entityKey  = new HeThongKey();
					entityKey.Load(values);
					item = HeThongProvider.Get(entityKey);
					results = new TList<HeThong>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case HeThongSelectMethod.GetAll:
                    results = HeThongProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case HeThongSelectMethod.GetPaged:
					results = HeThongProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case HeThongSelectMethod.Find:
					if ( FilterParameters != null )
						results = HeThongProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = HeThongProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case HeThongSelectMethod.GetByUserIdParentId:
					_userId = ( values["UserId"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["UserId"], typeof(System.Int32)) : (int)0;
					_parentId = ( values["ParentId"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["ParentId"], typeof(System.Int32)) : (int)0;
					item = HeThongProvider.GetByUserIdParentId(_userId, _parentId);
					results = new TList<HeThong>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				// FK
				case HeThongSelectMethod.GetByUserId:
					_userId = ( values["UserId"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["UserId"], typeof(System.Int32)) : (int)0;
					results = HeThongProvider.GetByUserId(_userId, this.StartIndex, this.PageSize, out count);
					break;
				case HeThongSelectMethod.GetByParentId:
					_parentId = ( values["ParentId"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["ParentId"], typeof(System.Int32)) : (int)0;
					results = HeThongProvider.GetByParentId(_parentId, this.StartIndex, this.PageSize, out count);
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
			if ( SelectMethod == HeThongSelectMethod.Get || SelectMethod == HeThongSelectMethod.GetByUserIdParentId )
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
				HeThong entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					HeThongProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<HeThong> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			HeThongProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region HeThongDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the HeThongDataSource class.
	/// </summary>
	public class HeThongDataSourceDesigner : ProviderDataSourceDesigner<HeThong, HeThongKey>
	{
		/// <summary>
		/// Initializes a new instance of the HeThongDataSourceDesigner class.
		/// </summary>
		public HeThongDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public HeThongSelectMethod SelectMethod
		{
			get { return ((HeThongDataSource) DataSource).SelectMethod; }
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
				actions.Add(new HeThongDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region HeThongDataSourceActionList

	/// <summary>
	/// Supports the HeThongDataSourceDesigner class.
	/// </summary>
	internal class HeThongDataSourceActionList : DesignerActionList
	{
		private HeThongDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the HeThongDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public HeThongDataSourceActionList(HeThongDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public HeThongSelectMethod SelectMethod
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

	#endregion HeThongDataSourceActionList
	
	#endregion HeThongDataSourceDesigner
	
	#region HeThongSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the HeThongDataSource.SelectMethod property.
	/// </summary>
	public enum HeThongSelectMethod
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
		/// Represents the GetByUserIdParentId method.
		/// </summary>
		GetByUserIdParentId,
		/// <summary>
		/// Represents the GetByUserId method.
		/// </summary>
		GetByUserId,
		/// <summary>
		/// Represents the GetByParentId method.
		/// </summary>
		GetByParentId
	}
	
	#endregion HeThongSelectMethod

	#region HeThongFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="HeThong"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HeThongFilter : SqlFilter<HeThongColumn>
	{
	}
	
	#endregion HeThongFilter

	#region HeThongExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="HeThong"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HeThongExpressionBuilder : SqlExpressionBuilder<HeThongColumn>
	{
	}
	
	#endregion HeThongExpressionBuilder	

	#region HeThongProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;HeThongChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="HeThong"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HeThongProperty : ChildEntityProperty<HeThongChildEntityTypes>
	{
	}
	
	#endregion HeThongProperty
}

