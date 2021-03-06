//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.Serialization;

namespace VideoStore.Business.Entities
{
    [DataContract(IsReference = true)]
    [KnownType(typeof(Recommendation))]
    [KnownType(typeof(Media))]
    public partial class LikeMatching: IObjectWithChangeTracker, INotifyPropertyChanged
    {
        #region Primitive Properties
    
        [DataMember]
        public int Id
        {
            get { return _id; }
            set
            {
                if (_id != value)
                {
                    if (ChangeTracker.ChangeTrackingEnabled && ChangeTracker.State != ObjectState.Added)
                    {
                        throw new InvalidOperationException("The property 'Id' is part of the object's key and cannot be changed. Changes to key properties can only be made when the object is not being tracked or is in the Added state.");
                    }
                    _id = value;
                    OnPropertyChanged("Id");
                }
            }
        }
        private int _id;
    
        [DataMember]
        public int count
        {
            get { return _count; }
            set
            {
                if (_count != value)
                {
                    _count = value;
                    OnPropertyChanged("count");
                }
            }
        }
        private int _count = 0;
    
        [DataMember]
        public int RecommendationId
        {
            get { return _recommendationId; }
            set
            {
                if (_recommendationId != value)
                {
                    ChangeTracker.RecordOriginalValue("RecommendationId", _recommendationId);
                    if (!IsDeserializing)
                    {
                        if (Recommendation != null && Recommendation.Id != value)
                        {
                            Recommendation = null;
                        }
                    }
                    _recommendationId = value;
                    OnPropertyChanged("RecommendationId");
                }
            }
        }
        private int _recommendationId;
    
        [DataMember]
        public byte[] Revision
        {
            get { return _revision; }
            set
            {
                if (_revision != value)
                {
                    ChangeTracker.RecordOriginalValue("Revision", _revision);
                    _revision = value;
                    OnPropertyChanged("Revision");
                }
            }
        }
        private byte[] _revision;

        #endregion
        #region Navigation Properties
    
        [DataMember]
        public Recommendation Recommendation
        {
            get { return _recommendation; }
            set
            {
                if (!ReferenceEquals(_recommendation, value))
                {
                    var previousValue = _recommendation;
                    _recommendation = value;
                    FixupRecommendation(previousValue);
                    OnNavigationPropertyChanged("Recommendation");
                }
            }
        }
        private Recommendation _recommendation;
    
        [DataMember]
        public Media Medium
        {
            get { return _medium; }
            set
            {
                if (!ReferenceEquals(_medium, value))
                {
                    var previousValue = _medium;
                    _medium = value;
                    FixupMedium(previousValue);
                    OnNavigationPropertyChanged("Medium");
                }
            }
        }
        private Media _medium;

        #endregion
        #region ChangeTracking
    
        protected virtual void OnPropertyChanged(String propertyName)
        {
            if (ChangeTracker.State != ObjectState.Added && ChangeTracker.State != ObjectState.Deleted)
            {
                ChangeTracker.State = ObjectState.Modified;
            }
            if (_propertyChanged != null)
            {
                _propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    
        protected virtual void OnNavigationPropertyChanged(String propertyName)
        {
            if (_propertyChanged != null)
            {
                _propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    
        event PropertyChangedEventHandler INotifyPropertyChanged.PropertyChanged{ add { _propertyChanged += value; } remove { _propertyChanged -= value; } }
        private event PropertyChangedEventHandler _propertyChanged;
        private ObjectChangeTracker _changeTracker;
    
        [DataMember]
        public ObjectChangeTracker ChangeTracker
        {
            get
            {
                if (_changeTracker == null)
                {
                    _changeTracker = new ObjectChangeTracker();
                    _changeTracker.ObjectStateChanging += HandleObjectStateChanging;
                }
                return _changeTracker;
            }
            set
            {
                if(_changeTracker != null)
                {
                    _changeTracker.ObjectStateChanging -= HandleObjectStateChanging;
                }
                _changeTracker = value;
                if(_changeTracker != null)
                {
                    _changeTracker.ObjectStateChanging += HandleObjectStateChanging;
                }
            }
        }
    
        private void HandleObjectStateChanging(object sender, ObjectStateChangingEventArgs e)
        {
            if (e.NewState == ObjectState.Deleted)
            {
                ClearNavigationProperties();
            }
        }
    
        protected bool IsDeserializing { get; private set; }
    
        [OnDeserializing]
        public void OnDeserializingMethod(StreamingContext context)
        {
            IsDeserializing = true;
        }
    
        [OnDeserialized]
        public void OnDeserializedMethod(StreamingContext context)
        {
            IsDeserializing = false;
            ChangeTracker.ChangeTrackingEnabled = true;
        }
    
        protected virtual void ClearNavigationProperties()
        {
            Recommendation = null;
            Medium = null;
            FixupMediumKeys();
            FixupVideoStoreEntityModel_RecommendationLikeMatching1_RecommendationKeys(null, true);
        }

        #endregion
        #region Association Fixup
    
        private void FixupRecommendation(Recommendation previousValue)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (previousValue != null && previousValue.LikeMatchings.Contains(this))
            {
                previousValue.LikeMatchings.Remove(this);
            }
    
            if (Recommendation != null)
            {
                if (!Recommendation.LikeMatchings.Contains(this))
                {
                    Recommendation.LikeMatchings.Add(this);
                }
    
                RecommendationId = Recommendation.Id;
            }
            if (ChangeTracker.ChangeTrackingEnabled)
            {
                if (ChangeTracker.OriginalValues.ContainsKey("Recommendation")
                    && (ChangeTracker.OriginalValues["Recommendation"] == Recommendation))
                {
                    ChangeTracker.OriginalValues.Remove("Recommendation");
                }
                else
                {
                    ChangeTracker.RecordOriginalValue("Recommendation", previousValue);
                }
                if (Recommendation != null && !Recommendation.ChangeTracker.ChangeTrackingEnabled)
                {
                    Recommendation.StartTracking();
                }
            }
        }
    
        private void FixupMedium(Media previousValue)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (previousValue != null && previousValue.LikeMatching.Contains(this))
            {
                previousValue.LikeMatching.Remove(this);
            }
    
            if (Medium != null)
            {
                if (!Medium.LikeMatching.Contains(this))
                {
                    Medium.LikeMatching.Add(this);
                }
    
            }
            if (ChangeTracker.ChangeTrackingEnabled)
            {
                if (ChangeTracker.OriginalValues.ContainsKey("Medium")
                    && (ChangeTracker.OriginalValues["Medium"] == Medium))
                {
                    ChangeTracker.OriginalValues.Remove("Medium");
                }
                else
                {
                    ChangeTracker.RecordOriginalValue("Medium", previousValue);
                }
                if (Medium != null && !Medium.ChangeTracker.ChangeTrackingEnabled)
                {
                    Medium.StartTracking();
                }
                FixupMediumKeys();
            }
        }
    
        private void FixupMediumKeys()
        {
            const string IdKeyName = "Medium.Id";
    
            if(ChangeTracker.ExtendedProperties.ContainsKey(IdKeyName))
            {
                if(Medium == null ||
                   !Equals(ChangeTracker.ExtendedProperties[IdKeyName], Medium.Id))
                {
                    ChangeTracker.RecordOriginalValue(IdKeyName, ChangeTracker.ExtendedProperties[IdKeyName]);
                }
                ChangeTracker.ExtendedProperties.Remove(IdKeyName);
            }
        }
    
        internal void FixupVideoStoreEntityModel_RecommendationLikeMatching1_RecommendationKeys(Recommendation value, bool forceRemove)
        {
            const string IdKeyName = "Navigate(VideoStoreEntityModel.RecommendationLikeMatching1.Recommendation).Id";
    
            if (ChangeTracker.ChangeTrackingEnabled &&
                ChangeTracker.ExtendedProperties.ContainsKey(IdKeyName))
            {
                if (forceRemove ||
                    !Equals(ChangeTracker.ExtendedProperties[IdKeyName], value == null ? null : (object)value.Id))
                {
                    ChangeTracker.RecordOriginalValue(IdKeyName, ChangeTracker.ExtendedProperties[IdKeyName]);
                    if (value == null)
                    {
                        ChangeTracker.ExtendedProperties.Remove(IdKeyName);
                    }
                    else
                    {
                        ChangeTracker.ExtendedProperties[IdKeyName] = value.Id;
                    }
                }
            }
        }

        #endregion
    }
}
