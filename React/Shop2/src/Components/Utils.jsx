import React from 'react';

const RedXOverlay = ({ children, isActive }) => {
  return (
    <div style={{ position: 'relative', display: 'inline-block' }}>
      {children}

      {isActive && (
        <div style={{
          position: 'absolute', 
          top: 0,
          left: 0,
          right: 0,
          bottom: 0,
          zIndex: 10,
          background: 'linear-gradient(to top right, transparent 45%, red 47%, red 53%, transparent 55%), linear-gradient(to top left, transparent 45%, red 47%, red 53%, transparent 55%)',
          backgroundSize: '100% 25px',
          backgroundPosition: 'center',
          backgroundRepeat: 'no-repeat'
        }}>
        </div>
      )}
    </div>
  );
};

export default RedXOverlay;