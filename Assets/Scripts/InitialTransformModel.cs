using Normal.Realtime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Normal.Realtime.Serialization;

[RealtimeModel]
public partial class InitialTransformModel
{
    [RealtimeProperty(1, true, true)] private Vector3 _position;
    [RealtimeProperty(2, true, true)] private Quaternion _rotation;

}

/* ----- Begin Normal Autogenerated Code ----- */
public partial class InitialTransformModel : RealtimeModel {
    public UnityEngine.Vector3 position {
        get {
            return _positionProperty.value;
        }
        set {
            if (_positionProperty.value == value) return;
            _positionProperty.value = value;
            InvalidateReliableLength();
            FirePositionDidChange(value);
        }
    }
    
    public UnityEngine.Quaternion rotation {
        get {
            return _rotationProperty.value;
        }
        set {
            if (_rotationProperty.value == value) return;
            _rotationProperty.value = value;
            InvalidateReliableLength();
            FireRotationDidChange(value);
        }
    }
    
    public delegate void PropertyChangedHandler<in T>(InitialTransformModel model, T value);
    public event PropertyChangedHandler<UnityEngine.Vector3> positionDidChange;
    public event PropertyChangedHandler<UnityEngine.Quaternion> rotationDidChange;
    
    public enum PropertyID : uint {
        Position = 1,
        Rotation = 2,
    }
    
    #region Properties
    
    private ReliableProperty<UnityEngine.Vector3> _positionProperty;
    
    private ReliableProperty<UnityEngine.Quaternion> _rotationProperty;
    
    #endregion
    
    public InitialTransformModel() : base(null) {
        _positionProperty = new ReliableProperty<UnityEngine.Vector3>(1, _position);
        _rotationProperty = new ReliableProperty<UnityEngine.Quaternion>(2, _rotation);
    }
    
    protected override void OnParentReplaced(RealtimeModel previousParent, RealtimeModel currentParent) {
        _positionProperty.UnsubscribeCallback();
        _rotationProperty.UnsubscribeCallback();
    }
    
    private void FirePositionDidChange(UnityEngine.Vector3 value) {
        try {
            positionDidChange?.Invoke(this, value);
        } catch (System.Exception exception) {
            UnityEngine.Debug.LogException(exception);
        }
    }
    
    private void FireRotationDidChange(UnityEngine.Quaternion value) {
        try {
            rotationDidChange?.Invoke(this, value);
        } catch (System.Exception exception) {
            UnityEngine.Debug.LogException(exception);
        }
    }
    
    protected override int WriteLength(StreamContext context) {
        var length = 0;
        length += _positionProperty.WriteLength(context);
        length += _rotationProperty.WriteLength(context);
        return length;
    }
    
    protected override void Write(WriteStream stream, StreamContext context) {
        var writes = false;
        writes |= _positionProperty.Write(stream, context);
        writes |= _rotationProperty.Write(stream, context);
        if (writes) InvalidateContextLength(context);
    }
    
    protected override void Read(ReadStream stream, StreamContext context) {
        var anyPropertiesChanged = false;
        while (stream.ReadNextPropertyID(out uint propertyID)) {
            var changed = false;
            switch (propertyID) {
                case (uint) PropertyID.Position: {
                    changed = _positionProperty.Read(stream, context);
                    if (changed) FirePositionDidChange(position);
                    break;
                }
                case (uint) PropertyID.Rotation: {
                    changed = _rotationProperty.Read(stream, context);
                    if (changed) FireRotationDidChange(rotation);
                    break;
                }
                default: {
                    stream.SkipProperty();
                    break;
                }
            }
            anyPropertiesChanged |= changed;
        }
        if (anyPropertiesChanged) {
            UpdateBackingFields();
        }
    }
    
    private void UpdateBackingFields() {
        _position = position;
        _rotation = rotation;
    }
    
}
/* ----- End Normal Autogenerated Code ----- */
