import styled from 'styled-components';

export const Container = styled.div`
  display: flex;
  align-items: center;
  justify-content: space-between;
  background-color: ${(props) => props.theme.colors.darker};
  height: 40px;
  padding: 20px;
`;

export const BoxItem = styled.div`
  display: flex;
  gap: 40px;
  color: #fff;
  font-size: 14px;

  button {
    background: transparent;
    border: none !important;
    outline: 0px auto -webkit-focus-ring-color;
  }
`;
